Imports DevExpress.Pdf
Imports System.Collections.Generic

Namespace RemoveAllMarkupAnnotations

    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            ' Create a PDF Document Processor.
            Using processor As New PdfDocumentProcessor()

                ' Load a document.
                processor.LoadDocument("..\..\Document.pdf")

                ' Get a list of annotations in the document pages.
                For i As Integer = 0 To processor.Document.Pages.Count
                    Dim annotations As IList(Of PdfMarkupAnnotationData) = processor.GetMarkupAnnotationData(i)

                    ' Delete all text markup annotations from document pages.
                    processor.DeleteMarkupAnnotations(annotations)

                    ' Save the result document.
                    processor.SaveDocument("..\..\Result.pdf")
                Next i
            End Using
        End Sub
    End Class
End Namespace