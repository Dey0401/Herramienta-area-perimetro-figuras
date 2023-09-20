<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHerencia.aspx.cs" Inherits="webPractica2.frmHerencia" %>

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
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" class="auto-style1">
                <tr>
                    <td aria-atomic="True" class="auto-style3">Construccion</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rblFiguras" runat="server" RepeatDirection="Horizontal" style="color: #FFFFFF; background-color: #000000" Width="260px" AutoPostBack="True" OnSelectedIndexChanged="rblFiguras_SelectedIndexChanged">
                            <asp:ListItem Selected="True" Value="opcCasa">Casa</asp:ListItem>
                            <asp:ListItem Value="opcRes">Residencial</asp:ListItem>
                            <asp:ListItem Value="opcEdi">Edificio</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Panel ID="pnlCasa" runat="server">
                            <table align="center" class="auto-style6">
                                <tr>
                                    <td class="auto-style8"></td>
                                    <td class="auto-style8"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Numero alcobas</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtAlcobas" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Nombre propietario</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtNombreProp" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style10"></td>
                                    <td class="auto-style10">
                                        &nbsp;</td>
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
                        <asp:Panel ID="pnlResidencial" runat="server" Visible="False">
                            <table align="center" class="auto-style6">
                                <tr>
                                    <td class="auto-style8"></td>
                                    <td class="auto-style8"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">Numero de bloques</td>
                                    <td class="auto-style8">
                                        <asp:TextBox ID="txtNroBloques" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Cerrada</td>
                                    <td class="auto-style7">
                                        <asp:CheckBox ID="chkCerrada" runat="server" OnCheckedChanged="chkCerrada_CheckedChanged" Text="si" />
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
                        <asp:Panel ID="pnlEdificio" runat="server" Visible="False">
                            <table align="center" class="auto-style6">
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style7">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Numero de pisos</td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtNroPisos" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">shut de basuras</td>
                                    <td class="auto-style7">
                                        <asp:CheckBox ID="chkShut" runat="server" OnCheckedChanged="chkCerrada_CheckedChanged" Text="si" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style8">
                                        &nbsp;</td>
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
                        <asp:Button ID="btnGuardar" runat="server" CssClass="auto-style11" OnClick="btnCalcular_Click" Text="Guardar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Panel ID="pnlRpta" runat="server" Visible="False">
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
