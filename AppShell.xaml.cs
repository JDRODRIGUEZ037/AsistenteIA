<<<<<<< HEAD
﻿using AsistenteIA.Views;

namespace AsistenteIA;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registro de ruta para navegación secundaria
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
}
=======
﻿namespace AsistenteIA
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> 5844a08c11593ddcc185a405b77a3ab0c256329b
