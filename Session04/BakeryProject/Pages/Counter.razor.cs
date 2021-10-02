using Microsoft.AspNetCore.Components;

namespace BakeryProject.Pages
{
    partial class Counter_razor : ComponentBase
    {
        
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
        
    }
}