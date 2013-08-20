#tag Class
Protected Class clsAPI
	#tag Method, Flags = &h0
		Sub Constructor(DataFile as String = "api.rsd")
		  db = new REALSQLDatabase
		  dbFile= new FolderItem(DataFile)
		  db.DatabaseFile= dbFile
		  db.AutoCommit=True
		  if not  dbFile.Exists then
		    
		    if db.CreateDatabaseFile then
		      db.SQLExecute " CREATE TABLE APIConfig (APIKey TEXT PRIMARY KEY, DeviceID TEXT, SensorID TEXT, APIVer TEXT, Flag TEXT, DisplayKey TEXT); "
		      dim r as new  DatabaseRecord
		      r.Column("apikEY")="89501b438791e28f74c21035a88"
		      r.Column("DeviceID")="0"
		      r.Column("SensorID")="0"
		      r.Column("APIVer")="v1.0"
		      r.Column("Flag")="value"
		      r.Column("DisplayKey")="0"
		      
		      DB.InsertRecord "APIConfig", r
		      
		      if db.Error then
		        MsgBox "charu shibai"
		      end
		      
		    else
		      MsgBox "无法创建配置文档"
		    End
		  Else
		    '连接数据库
		    if not db.Connect then
		      MsgBox "无法打开配置文档"
		    else
		      
		    end
		    
		  End
		  
		  
		  
		  
		End Sub
	#tag EndMethod

	#tag Method, Flags = &h0
		Sub Destructor()
		  db.Close
		  
		End Sub
	#tag EndMethod

	#tag Method, Flags = &h0
		Function ExistAPI(APIKey as String = "") As Boolean
		  DIM rs as RecordSet
		  if APIKey="" then
		    rs= db.SQLSelect ("SELECT * FROM APIConfig;")
		  Else
		    rs=db.SQLSelect("SELECT APIKey FROM APICONFIG WHERE APIKEY="+ APIKey +";")
		  End
		  
		  dim ret as Boolean
		  
		  ret= rs<>nil
		  
		  rs.Close
		  
		  Return ret
		  
		End Function
	#tag EndMethod

	#tag Method, Flags = &h0
		Function GetAPIKey() As String
		  Return GetStringValue("APIKey")
		End Function
	#tag EndMethod

	#tag Method, Flags = &h0
		Function GetAPIVersion() As String
		  Return GetStringValue("apiver")
		End Function
	#tag EndMethod

	#tag Method, Flags = &h0
		Function GetBooleanValue(KeyName as String) As Boolean
		  DIM rs as RecordSet
		  
		  rs= db.SQLSelect ("SELECT "+ KeyName+" FROM APIConfig;")
		  
		  
		  dim ret as Boolean
		  
		  ret= rs.Field(KeyName).BooleanValue
		  
		  
		  rs.Close
		  
		  Return ret
		End Function
	#tag EndMethod

	#tag Method, Flags = &h0
		Function GetDeviceID() As String
		  return GetStringValue("DeviceID")
		End Function
	#tag EndMethod

	#tag Method, Flags = &h0
		Function GetDisplayKey() As Boolean
		  DIM v as String
		  dim ret as Boolean
		  v=GetStringValue("DisplayKey")
		  if v="0" then
		    ret=False
		  else
		    ret=True
		  end
		  Return ret
		  
		End Function
	#tag EndMethod

	#tag Method, Flags = &h0
		Function GetSensorID() As String
		  Return GetStringValue("SensorID")
		End Function
	#tag EndMethod

	#tag Method, Flags = &h0
		Function GetStringValue(KeyName as String) As String
		  DIM rs as RecordSet
		  
		  rs= db.SQLSelect ("SELECT "+ KeyName+" FROM APIConfig;")
		  
		  
		  dim ret as String
		  ret= rs.Field(KeyName).StringValue
		  
		  
		  rs.Close
		  
		  Return ret
		End Function
	#tag EndMethod

	#tag Method, Flags = &h0
		Function GetValueFlag() As String
		  Return GetStringValue("Flag")
		  
		End Function
	#tag EndMethod

	#tag Method, Flags = &h0
		Sub SetAPIKey(Value as string)
		  SetStringValue("APIKey",Value)
		End Sub
	#tag EndMethod

	#tag Method, Flags = &h0
		Sub SetAPIVersion(value as string)
		  SetStringValue("APIVer", value )
		End Sub
	#tag EndMethod

	#tag Method, Flags = &h0
		Sub SetBooleanValue(KeyName as string, Value as Boolean)
		  dim v as String
		  if Value then
		    v="-1"
		  else
		    v="0"
		  end
		  
		  db.SQLExecute("Begin Transaction")
		  db.SQLExecute "UPDATE APIConfig SET "+ KeyName+ "= "+v+";"
		  db.SQLExecute "END Transaction"
		  
		  
		End Sub
	#tag EndMethod

	#tag Method, Flags = &h0
		Sub SetDeviceID(value as string)
		  SetStringValue("DeviceID", value )
		End Sub
	#tag EndMethod

	#tag Method, Flags = &h0
		Sub SetDisplayKey(value as Boolean)
		  if value then
		    SetStringValue("DisplayKey", "-1")
		  ELSE
		    SetStringValue("DisplayKey","0")
		  end
		  
		End Sub
	#tag EndMethod

	#tag Method, Flags = &h0
		Sub SetSensorID(value as string)
		  SetStringValue("SensorID", value)
		End Sub
	#tag EndMethod

	#tag Method, Flags = &h0
		Sub SetStringValue(KeyName as string, Value as String)
		  db.SQLExecute("Begin Transaction")
		  db.SQLExecute "UPDATE APIConfig SET  "+ KeyName +" = '"+ Value+"';"
		  db.SQLExecute "END Transaction"
		End Sub
	#tag EndMethod

	#tag Method, Flags = &h0
		Sub SetValueFlag(value as string)
		  SetStringValue("FLAG",value)
		End Sub
	#tag EndMethod


	#tag Property, Flags = &h21
		Private DB As REALSQLDatabase
	#tag EndProperty

	#tag Property, Flags = &h21
		Private dbFile As FolderItem
	#tag EndProperty


	#tag ViewBehavior
		#tag ViewProperty
			Name="Index"
			Visible=true
			Group="ID"
			InitialValue="-2147483648"
			InheritedFrom="Object"
		#tag EndViewProperty
		#tag ViewProperty
			Name="Left"
			Visible=true
			Group="Position"
			InitialValue="0"
			InheritedFrom="Object"
		#tag EndViewProperty
		#tag ViewProperty
			Name="Name"
			Visible=true
			Group="ID"
			InheritedFrom="Object"
		#tag EndViewProperty
		#tag ViewProperty
			Name="Super"
			Visible=true
			Group="ID"
			InheritedFrom="Object"
		#tag EndViewProperty
		#tag ViewProperty
			Name="Top"
			Visible=true
			Group="Position"
			InitialValue="0"
			InheritedFrom="Object"
		#tag EndViewProperty
	#tag EndViewBehavior
End Class
#tag EndClass
