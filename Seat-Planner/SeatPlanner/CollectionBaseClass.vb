Public Class CollectionBaseClass
  Inherits System.Collections.CollectionBase

  Default Public Property Item(ByVal index As Short) As Object
    Get
      Return List(index)
    End Get
    Set(ByVal value As Object)
      List.Item(index) = value
    End Set
  End Property

  Public Function Add(ByVal value As Object) As Short
    Return List.Add(value)
  End Function

  Public Sub Insert(ByVal index As Short, ByVal value As Object)
    List.Insert(index, value)
  End Sub

  Public Sub Remove(ByVal value As Object)
    List.Remove(value)
  End Sub
End Class
