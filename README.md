# Add-Annotation-in-MAUI-ImageEditor

This sample demonstrates how to add Annotation in MAUI ImageEditor control within a .NET MAUI application. You'll see how to add text, and shape annotations, programmatically select annotations and create freehand drawings.

## Sample

```xaml
<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.png"
                               ImageLoaded="OnImageEditorLoaded">

    </imageEditor:SfImageEditor>
    <StackLayout Grid.Row="1" Margin="10" Orientation="Horizontal">
        <Label Text="ShapeID :" VerticalOptions="Center" />
        <Entry x:Name="shape" WidthRequest ="50" HeightRequest="50"/>
        <Button Text="SelectShape" Margin="25,0,0,0" Clicked="SelectShape_Clicked" WidthRequest="150" />
    </StackLayout>
</Grid>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.
