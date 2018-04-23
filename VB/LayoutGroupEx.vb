Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.Docking

Namespace CustomLayoutGroup.Common
    Public Class LayoutGroupEx
        Inherits LayoutGroup

        Protected Overrides Function CoerceGroupBorderStyle(ByVal value As GroupBorderStyle) As GroupBorderStyle
            Return value
        End Function
    End Class
End Namespace
