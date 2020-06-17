Public Class Encryptor
    Public Shared Function Encrypt(strText As String, strEntropy As String) As String
        Dim byteEntropy As Byte() = System.Text.Encoding.ASCII.GetBytes(strEntropy)
        Dim byteTextDecrypted As Byte() = System.Text.Encoding.ASCII.GetBytes(strText.ToCharArray)
        Dim byteTextEncrypted As Byte() = ProtectedData.Protect(byteTextDecrypted, byteEntropy, DataProtectionScope.CurrentUser)
        Return Convert.ToBase64String(byteTextEncrypted)
    End Function

    Public Shared Function Decrypt(strText As String, strEntropy As String) As String
        Dim byteEntropy As Byte() = System.Text.Encoding.ASCII.GetBytes(strEntropy)
        Dim byteTextEncrypted As Byte() = Convert.FromBase64String(strText)
        Dim byteTextDecrypted As Byte() = ProtectedData.Unprotect(byteTextEncrypted, byteEntropy, DataProtectionScope.CurrentUser)
        Return System.Text.Encoding.ASCII.GetString(byteTextDecrypted)
    End Function
End Class
