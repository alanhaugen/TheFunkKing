#ifndef ENTERTAINER_H
#define ENTERTAINER_H

#include <core/components/actor.h>
#include <core/components/text.h>
#include <core/components/sprite.h>
#include "styles.h"

class Entertainer : public Actor
{
public:
    Entertainer();

    void Hide();
    void Entertain();

    Sprite* appearance;
    String description;
    String name;
    float skill;
    int style;
    //Ticks (?)

    Text* text1;
    Text* text2;
    Text* text3;

private:
    float clowndance;
    bool isRejected;
};

#endif // ENTERTAINER_H
