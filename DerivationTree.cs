using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using QuickGraph;
using QuickGraph.Graphviz;
using QuickGraph.Graphviz.Dot;

public class DerivationTree
{
    private Node root;
    private BidirectionalGraph<Node, Edge<Node>> graph;

    public DerivationTree()
    {
        root = null;
        graph = new BidirectionalGraph<Node, Edge<Node>>();
    }

    public void BuildTree(string input)
    {
        var tokens = Tokenize(input);
        var index = 0;
        root = ParseE(tokens, ref index);
        BuildGraph(root);
    }

    private Node ParseE(List<string> tokens, ref int index)
    {
        var node = new Node("E");
        node.Children.Add(ParseT(tokens, ref index));
        node.Children.Add(ParseEp(tokens, ref index));
        return node;
    }

    private Node ParseEp(List<string> tokens, ref int index)
    {
        var node = new Node("Ep");

        if (index < tokens.Count && tokens[index] == "or")
        {
            node.Children.Add(new Node("or"));
            index++;
            node.Children.Add(ParseT(tokens, ref index));
            node.Children.Add(ParseEp(tokens, ref index));
        }
        else
        {
            node.Children.Add(new Node("epsilon"));
        }

        return node;
    }

    private Node ParseT(List<string> tokens, ref int index)
    {
        var node = new Node("T");
        node.Children.Add(ParseC(tokens, ref index));
        node.Children.Add(ParseTp(tokens, ref index));
        return node;
    }

    private Node ParseTp(List<string> tokens, ref int index)
    {
        var node = new Node("Tp");

        if (index < tokens.Count && tokens[index] == "conc")
        {
            node.Children.Add(new Node("conc"));
            index++;
            node.Children.Add(ParseC(tokens, ref index));
            node.Children.Add(ParseTp(tokens, ref index));
        }
        else
        {
            node.Children.Add(new Node("epsilon"));
        }

        return node;
    }

    private Node ParseC(List<string> tokens, ref int index)
    {
        var node = new Node("C");
        node.Children.Add(ParseF(tokens, ref index));
        node.Children.Add(ParseCp(tokens, ref index));
        return node;
    }

    private Node ParseCp(List<string> tokens, ref int index)
    {
        var node = new Node("Cp");

        if (index < tokens.Count)
        {
            var token = tokens[index];

            if (token == "CerrPos" || token == "CerrK" || token == "Opc")
            {
                node.Children.Add(new Node(token));
                index++;
                node.Children.Add(ParseCp(tokens, ref index));
            }
            else
            {
                node.Children.Add(new Node("epsilon"));
            }
        }
        else
        {
            node.Children.Add(new Node("epsilon"));
        }

        return node;
    }

    private Node ParseF(List<string> tokens, ref int index)
    {
        var node = new Node("F");

        if (index < tokens.Count)
        {
            var token = tokens[index];

            if (token == "Parizq")
            {
                node.Children.Add(new Node("Parizq"));
                index++;
                node.Children.Add(ParseE(tokens, ref index));

                if (index < tokens.Count && tokens[index] == "ParDer")
                {
                    node.Children.Add(new Node("ParDer"));
                    index++;
                }
                else
                {
                    throw new Exception("Error de sintaxis: Se esperaba ')' después de una expresión.");
                }
            }
            else if (token == "simb")
            {
                node.Children.Add(new Node("simb"));
                index++;
            }
            else if (token == "CorchIz")
            {
                node.Children.Add(new Node("CorchIz"));
                index++;

                if (index < tokens.Count && tokens[index] == "simb")
                {
                    node.Children.Add(new Node("simb"));
                    index++;

                    if (index < tokens.Count && tokens[index] == "guion")
                    {
                        node.Children.Add(new Node("guion"));
                        index++;

                        if (index < tokens.Count && tokens[index] == "simb")
                        {
                            node.Children.Add(new Node("simb"));
                            index++;

                            if (index < tokens.Count && tokens[index] == "CorchDer")
                            {
                                node.Children.Add(new Node("CorchDer"));
                                index++;
                            }
                            else
                            {
                                throw new Exception("Error de sintaxis: Se esperaba ']' después de un símbolo.");
                            }
                        }
                        else
                        {
                            throw new Exception("Error de sintaxis: Se esperaba un símbolo después de '-' en una expresión de rango.");
                        }
                    }
                    else
                    {
                        throw new Exception("Error de sintaxis: Se esperaba '-' después de un símbolo en una expresión de rango.");
                    }
                }
                else
                {
                    throw new Exception("Error de sintaxis: Se esperaba un símbolo después de '['.");
                }
            }
            else
            {
                throw new Exception($"Error de sintaxis: Token inesperado '{token}'.");
            }
        }
        else
        {
            throw new Exception("Error de sintaxis: La expresión está incompleta.");
        }

        return node;
    }

    private List<string> Tokenize(string input)
    {
        var tokens = new List<string>();

        foreach (var c in input)
        {
            if (c == '(')
            {
                tokens.Add("Parizq");
            }
            else if (c == ')')
            {
                tokens.Add("ParDer");
            }
            else if (c == '|')
            {
                tokens.Add("or");
            }
            else if (c == '[')
            {
                tokens.Add("CorchIz");
            }
            else if (c == ']')
            {
                tokens.Add("CorchDer");
            }
            else if (c == '-')
            {
                tokens.Add("guion");
            }
            else if (c == ' ')
            {
                continue;
            }
            else
            {
                tokens.Add("simb");
            }
        }

        return tokens;
    }

    private void BuildGraph(Node node)
    {
        graph.AddVertex(node);

        foreach (var child in node.Children)
        {
            graph.AddEdge(new Edge<Node>(node, child));
            BuildGraph(child);
        }
    }

    public void SaveGraph(string filename)
    {
        var graphviz = new GraphvizAlgorithm<Node, Edge<Node>>(graph);
        graphviz.FormatVertex += FormatVertex;
        graphviz.FormatEdge += FormatEdge;

        using (var fileStream = new FileStream(filename, FileMode.Create))
        {
            graphviz.Generate(fileStream);
        }
    }

    private void FormatVertex(object sender, FormatVertexEventArgs<Node> e)
    {
        var shape = e.Vertex.Value == "epsilon" ? GraphvizVertexShape.None : GraphvizVertexShape.Box;
        e.VertexFormatter.Shape = shape;
        e.VertexFormatter.Label = e.Vertex.Value;
    }

    private void FormatEdge(object sender, FormatEdgeEventArgs<Node, Edge<Node>> e)
    {
        e.EdgeFormatter.Label = "";
    }
}