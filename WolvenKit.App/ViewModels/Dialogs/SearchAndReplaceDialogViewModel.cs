using CommunityToolkit.Mvvm.ComponentModel;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// A simple "search and replace" dialog. Needs to register in GenericHost via AddTransient.
/// </summary>
public partial class SearchAndReplaceDialogViewModel() : ObservableObject
{
       
    /// <summary>
    /// Search text 
    /// </summary>
    [ObservableProperty] private string? _searchText = "";

    /// <summary>
    /// Replace text
    /// </summary>
    [ObservableProperty] private string? _replaceText = "";

    /// <summary>
    ///Ignore case
    /// </summary>
    [ObservableProperty] private bool _rememberValues;

    /// <summary>
    /// Whole word only?
    /// </summary>
    [ObservableProperty] private bool _isWholeWord;

    /// <summary>
    /// Regular expression?
    /// </summary>
    [ObservableProperty] private bool _isRegex;
    
    

    public void SwapFields() => (SearchText, ReplaceText) = (ReplaceText, SearchText);
}