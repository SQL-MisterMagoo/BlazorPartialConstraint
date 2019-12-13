using Microsoft.AspNetCore.Components;

namespace BlazorPartialConstraint.Shared
{
    public partial class ConstrainedComponent<TItem> where TItem : new()
    {
        [Parameter] public TItem SomeThing { get; set; } 
    }
}
