<Serializable> Public Class GraphDef
   Public ValueIndex    As Integer
   Public GraphName    As String
   Public Minimum       As Integer
   Public Maximum       As Integer
   Public TickSpacing   As Integer

   Public Sub New(index As Integer, name As String)
      ValueIndex = index
      GraphName = name
      Minimum = 0
      Maximum = 100
      TickSpacing = 10
   End Sub

   Public Overrides Function ToString() As String
      Return GraphName 
   End Function

End Class
