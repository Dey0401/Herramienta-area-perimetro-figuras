﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHerencia.aspx.cs" Inherits="webPractica2.frmHerencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Practica #2 herencia y polimorfismo</title>
    <style type="text/css">
        .auto-style1 {
            width: 80%; 
            border: 3px solid #0000FF;
            background-color: #000000;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 80%;
            text-align: center;
            color: #FFFFFF;
            border: 3px solid #0000FF;
            background-color: #000000;
            font-size: x-large;
            font-family: Calibri;
        }
        .auto-style4 {
            text-align: center;
            height: 23px;
        }
        .auto-style5 {
            text-align: center;
            color: #FF0000;
        }
        .auto-style6 {
            width: 80%;
        }
        .auto-style7 {
            background-color: #FFFFFF;
        }
        .auto-style8 {
            height: 23px;
            background-color: #FFFFFF;
        }
        .auto-style10 {
            height: 15px;
            background-color: #FFFFFF;
        }
        .auto-style11 {
            color: #FFFFFF;
            background-color: #FF0000;
        }
        .auto-style12 {
            color: #FFFFFF;
        }
        .auto-style13 {
            color: #FFFFFF;
            height: 26px;
        }
        .auto-style14 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" class="auto-style1">
                <tr>
                    <td aria-atomic="True" class="auto-style3"><strong>Canculos Figuras Geometrizas 2D</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="rblFiguras" runat="server" RepeatDirection="Horizontal" style="color: #FFFFFF; background-color: #000000" Width="260px">
                            <asp:ListItem Selected="True" Value="opcTri">Triángulo</asp:ListItem>
                            <asp:ListItem Value="opcRec">Rectángulo</asp:ListItem>
                            <asp:ListItem Value="opcRom">Rombo</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Image ID="imgFiguras" runat="server" Width="25%" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">[lblMsj]</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Panel ID="pnlTriangulo" runat="server">
                            <table align="center" class="auto-style6">
                                <tr>
                                    <td class="auto-style8"></td>
                                    <td class="auto-style8"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Lado A</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtLadoA" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Lado B</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtLadoB" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style10">Angulo</td>
                                    <td class="auto-style10">
                                        <asp:TextBox ID="txtAngulo" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style7">&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Panel ID="pnlRectangulo" runat="server">
                            <table align="center" class="auto-style6">
                                <tr>
                                    <td class="auto-style8"></td>
                                    <td class="auto-style8"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">Lado 1</td>
                                    <td class="auto-style8">
                                        <asp:TextBox ID="txtLado1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Lado 2</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtLado2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style7">&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Panel ID="pnlRombo" runat="server">
                            <table align="center" class="auto-style6">
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style7">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Diagonal mayor</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtDiagMy" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Diagonal menor</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtDiagMn" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">Lado</td>
                                    <td class="auto-style8">
                                        <asp:TextBox ID="txtLado" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style7">&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnCalcular" runat="server" CssClass="auto-style11" OnClick="Button1_Click" Text="Calcular" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Panel ID="pnlRpta" runat="server">
                            <table align="center" class="auto-style6">
                                <tr>
                                    <td class="auto-style13">Area</td>
                                    <td class="auto-style14">
                                        <asp:Label ID="lblArea" runat="server" CssClass="auto-style12"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style12">Perimetro</td>
                                    <td>
                                        <asp:Label ID="lblPerim" runat="server" CssClass="auto-style12"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
            </table>

        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
