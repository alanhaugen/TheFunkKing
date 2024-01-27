#include <core/application.h>
#include "splash.h"
#include "mainmenu.h"
#include "game.h"

int main(int argc, char **argv)
{
    Application application(argc, argv);
    application.AddScene(new Splash());
    application.AddScene(new MainMenu());
    application.AddScene(new Game());

    return application.Exec();
}

