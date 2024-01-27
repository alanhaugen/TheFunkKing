#ifndef MAINMENU_H
#define MAINMENU_H

#include <core/x-platform/scene.h>
#include <core/components/text.h>

class MainMenu : public IScene
{
public:
    MainMenu();

    Text *text;
    Text *option1;
    Text *option2;
    Text *option3;
    Text *option4;
    Text *option5;

    Text *selector;

    int option;

    void Init();
    void Update();
    void UpdateAfterPhysics();
};

#endif
