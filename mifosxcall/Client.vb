Public Class Client
    Public Class create

        Public Property officeId() As Integer
            Get
                Return m_officeId
            End Get
            Set
                m_officeId = Value
            End Set
        End Property
        Private m_officeId As Integer
        Public Property clientId() As Integer
            Get
                Return m_clientId
            End Get
            Set
                m_clientId = Value
            End Set
        End Property
        Private m_clientId As Integer
        Public Property resourceId() As Integer
            Get
                Return m_resourceId
            End Get
            Set
                m_resourceId = Value
            End Set
        End Property
        Private m_resourceId As Integer
        Public Property savingsId() As Integer
            Get
                Return m_savingsId
            End Get
            Set
                m_savingsId = Value
            End Set
        End Property
        Private m_savingsId As Integer
    End Class
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================




