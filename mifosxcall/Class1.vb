Public Class Class1

    Public Class Status
        Public Property id() As Integer
            Get
                Return m_id
            End Get
            Set
                m_id = Value
            End Set
        End Property
        Private m_id As Integer
        Public Property code() As String
            Get
                Return m_code
            End Get
            Set
                m_code = Value
            End Set
        End Property
        Private m_code As String
        Public Property value() As String
            Get
                Return m_value
            End Get
            Set
                m_value = Value
            End Set
        End Property
        Private m_value As String
    End Class

    Public Class SubStatus
    End Class

    Public Class Gender
        Public Property id() As System.Nullable(Of Integer)
            Get
                Return m_id
            End Get
            Set
                m_id = Value
            End Set
        End Property
        Private m_id As System.Nullable(Of Integer)
        Public Property name() As String
            Get
                Return m_name
            End Get
            Set
                m_name = Value
            End Set
        End Property
        Private m_name As String
    End Class

    Public Class ClientType
    End Class

    Public Class ClientClassification
    End Class

    Public Class Timeline
        Public Property submittedOnDate() As List(Of Integer)
            Get
                Return m_submittedOnDate
            End Get
            Set
                m_submittedOnDate = Value
            End Set
        End Property
        Private m_submittedOnDate As List(Of Integer)
        Public Property submittedByUsername() As String
            Get
                Return m_submittedByUsername
            End Get
            Set
                m_submittedByUsername = Value
            End Set
        End Property
        Private m_submittedByUsername As String
        Public Property submittedByFirstname() As String
            Get
                Return m_submittedByFirstname
            End Get
            Set
                m_submittedByFirstname = Value
            End Set
        End Property
        Private m_submittedByFirstname As String
        Public Property submittedByLastname() As String
            Get
                Return m_submittedByLastname
            End Get
            Set
                m_submittedByLastname = Value
            End Set
        End Property
        Private m_submittedByLastname As String
        Public Property activatedOnDate() As List(Of Integer)
            Get
                Return m_activatedOnDate
            End Get
            Set
                m_activatedOnDate = Value
            End Set
        End Property
        Private m_activatedOnDate As List(Of Integer)
        Public Property activatedByUsername() As String
            Get
                Return m_activatedByUsername
            End Get
            Set
                m_activatedByUsername = Value
            End Set
        End Property
        Private m_activatedByUsername As String
        Public Property activatedByFirstname() As String
            Get
                Return m_activatedByFirstname
            End Get
            Set
                m_activatedByFirstname = Value
            End Set
        End Property
        Private m_activatedByFirstname As String
        Public Property activatedByLastname() As String
            Get
                Return m_activatedByLastname
            End Get
            Set
                m_activatedByLastname = Value
            End Set
        End Property
        Private m_activatedByLastname As String
    End Class

    Public Class PageItem
        Public Property id() As Integer
            Get
                Return m_id
            End Get
            Set
                m_id = Value
            End Set
        End Property
        Private m_id As Integer
        Public Property accountNo() As String
            Get
                Return m_accountNo
            End Get
            Set
                m_accountNo = Value
            End Set
        End Property
        Private m_accountNo As String
        Public Property status() As Status
            Get
                Return m_status
            End Get
            Set
                m_status = Value
            End Set
        End Property
        Private m_status As Status
        Public Property subStatus() As SubStatus
            Get
                Return m_subStatus
            End Get
            Set
                m_subStatus = Value
            End Set
        End Property
        Private m_subStatus As SubStatus
        Public Property active() As Boolean
            Get
                Return m_active
            End Get
            Set
                m_active = Value
            End Set
        End Property
        Private m_active As Boolean
        Public Property activationDate() As List(Of Integer)
            Get
                Return m_activationDate
            End Get
            Set
                m_activationDate = Value
            End Set
        End Property
        Private m_activationDate As List(Of Integer)
        Public Property firstname() As String
            Get
                Return m_firstname
            End Get
            Set
                m_firstname = Value
            End Set
        End Property
        Private m_firstname As String
        Public Property lastname() As String
            Get
                Return m_lastname
            End Get
            Set
                m_lastname = Value
            End Set
        End Property
        Private m_lastname As String
        Public Property displayName() As String
            Get
                Return m_displayName
            End Get
            Set
                m_displayName = Value
            End Set
        End Property
        Private m_displayName As String


        Public Property govid() As String
            Get
                Return m_govid
            End Get
            Set
                m_govid = Value
            End Set
        End Property
        Private m_govid As String


        Public Property gender() As Gender
            Get
                Return m_gender
            End Get
            Set
                m_gender = Value
            End Set
        End Property
        Private m_gender As Gender
        Public Property clientType() As ClientType
            Get
                Return m_clientType
            End Get
            Set
                m_clientType = Value
            End Set
        End Property
        Private m_clientType As ClientType
        Public Property clientClassification() As ClientClassification
            Get
                Return m_clientClassification
            End Get
            Set
                m_clientClassification = Value
            End Set
        End Property
        Private m_clientClassification As ClientClassification
        Public Property officeId() As Integer
            Get
                Return m_officeId
            End Get
            Set
                m_officeId = Value
            End Set
        End Property
        Private m_officeId As Integer
        Public Property officeName() As String
            Get
                Return m_officeName
            End Get
            Set
                m_officeName = Value
            End Set
        End Property
        Private m_officeName As String
        Public Property staffId() As Integer
            Get
                Return m_staffId
            End Get
            Set
                m_staffId = Value
            End Set
        End Property
        Private m_staffId As Integer
        Public Property staffName() As String
            Get
                Return m_staffName
            End Get
            Set
                m_staffName = Value
            End Set
        End Property
        Private m_staffName As String
        Public Property timeline() As Timeline
            Get
                Return m_timeline
            End Get
            Set
                m_timeline = Value
            End Set
        End Property
        Private m_timeline As Timeline
        Public Property middlename() As String
            Get
                Return m_middlename
            End Get
            Set
                m_middlename = Value
            End Set
        End Property
        Private m_middlename As String
        Public Property mobileNo() As String
            Get
                Return m_mobileNo
            End Get
            Set
                m_mobileNo = Value
            End Set
        End Property
        Private m_mobileNo As String
        Public Property dateOfBirth() As List(Of System.Nullable(Of Integer))
            Get
                Return m_dateOfBirth
            End Get
            Set
                m_dateOfBirth = Value
            End Set
        End Property
        Private m_dateOfBirth As List(Of System.Nullable(Of Integer))
    End Class

    Public Class RootObject
        Public Property totalFilteredRecords() As Integer
            Get
                Return m_totalFilteredRecords
            End Get
            Set
                m_totalFilteredRecords = Value
            End Set
        End Property
        Private m_totalFilteredRecords As Integer
        Public Property pageItems() As List(Of PageItem)
            Get
                Return m_pageItems
            End Get
            Set
                m_pageItems = Value
            End Set
        End Property
        Private m_pageItems As List(Of PageItem)
    End Class

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by NRefactory.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================


End Class
