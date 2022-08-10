Public Class GuestClass
  Private m_Name As String
  Private m_GradYear As Short
  Private m_Sex As Short

  Public Property Name() As String
    Get
      Return m_Name
    End Get
    Set(ByVal value As String)
      m_Name = value
    End Set
  End Property

  Public Property GradYear() As Short
    Get
      Return m_GradYear
    End Get
    Set(ByVal value As Short)
      m_GradYear = value
    End Set
  End Property

  Public Property Sex() As Short
    Get
      Return m_Sex
    End Get
    Set(ByVal value As Short)
      m_Sex = value
    End Set
  End Property
End Class
