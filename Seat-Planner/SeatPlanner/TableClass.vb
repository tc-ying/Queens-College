Public Class TableClass
  Inherits SeatPlanner.CollectionBaseClass
  Private m_SexBalance As Short

  Public Property SexBalance() As Short
    Get
      Return m_SexBalance
    End Get
    Set(ByVal value As Short)
      m_SexBalance = value
    End Set
  End Property
End Class
