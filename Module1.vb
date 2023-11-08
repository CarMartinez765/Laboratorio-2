Module Module1

    Sub Main()
        Dim totalCompra As Double = 0
        Dim descuento As Double = 0
        Dim compra As Double
        Dim dineroEntregado As Double

        Do
            Console.Write("Ingrese el costo del artículo ")
            compra = Double.Parse(Console.ReadLine())



            If compra >= 0 Then
                totalCompra += compra

                If totalCompra > 500 Then
                    descuento = totalCompra * 0.05
                ElseIf totalCompra > 1000 Then
                    descuento = totalCompra * 0.1
                End If

                Console.Write("Ingrese la cantidad de dinero entregada por el cliente....: ")
                dineroEntregado = Double.Parse(Console.ReadLine())

                If dineroEntregado > totalCompra - descuento Then
                    Dim cambio As Double = dineroEntregado - (totalCompra - descuento)
                    Console.WriteLine("Cambio a entregar: $" & cambio)
                ElseIf dineroEntregado = totalCompra - descuento Then
                    Console.WriteLine("Entrega del producto.")
                Else
                    Console.WriteLine("El cliente debe pagar $" & (totalCompra - descuento - dineroEntregado) & " más.")
                    Console.WriteLine("El cliente no tiene suficiente dinero para la compra.")
                    Console.WriteLine("Por favor, vuelva pronto por el producto que desea.")
                    Console.WriteLine("Desarrolladores Carmen Magdalena Vasquez Martinez, Andy Adonay Hernandez Corado")
                End If
            End If
        Loop While compra >= 0






    End Sub

End Module
