import "../solid/solid.qbs" as solid

solid {
    Application {
        name: "TheKingsMood"

        files: [
            "data/Entertainer1",
            "data/Entertainers/clown.txt",
            "data/bg.frag",
            "data/bg.vert",
            "data/cubemap.frag",
            "data/cubemap.vert",
            "data/entertainer.kra",
            "data/entertainer.png",
            "data/entertainer.png~",
            "data/gouraud.frag",
            "data/gouraud.vert",
            "data/app.rc",
            "data/app.res",
            "data/gui.frag",
            "data/gui.vert",
            "data/icon.png",
            "data/icon_1024x1024.png",
            "data/icon_128x128.png",
            "data/icon_16x16.png",
            "data/icon_256x256.png",
            "data/icon_32x32.png",
            "data/icon_512x512.png",
            "data/icon_64x64.png",
            "data/icon_96x96.png",
            "data/level1.json",
            "data/logo.png",
            "data/logo_inv.png",
            "data/logo_inv_jpg.jpg",
            "data/phong.frag",
            "data/phong.vert",
            "data/project.json",
            "data/sheet.png",
            "data/simple.frag",
            "data/simple.vert",
            "data/solid.ico",
            "data/splash.kra",
            "data/splash.png",
            "data/throne_room.kra",
            "data/throne_room.png",
            "data/vertexanimation.frag",
            "data/vertexanimation.vert",
            "source/entertainer.cpp",
            "source/entertainer.h",
            "source/main.cpp",
            "source/main.h",
            "source/mainmenu.cpp",
            "source/mainmenu.h",
            "source/splash.cpp",
            "source/splash.h",
            "source/game.cpp",
            "source/game.h",
            "source/styles.h",
        ]

        Depends { name: "core"  }
        Depends { name: "nullrenderer"  }
        Depends { name: "nullphysics"  }
        Depends { name: "nullaudio"  }
        Depends { name: "nullphysics"  }
        Depends { name: "nullfilesystem"  }
        Depends { name: "gles2renderer"  }
        Depends { name: "stdfilesystem"  }
        Depends { name: "portaudioaudio"  }

        property stringList includePaths: "../solid/source"

        Properties {
            condition: qbs.targetOS.contains("macos")

            cpp.frameworks: macosFrameworks

            cpp.dynamicLibraries: macosSharedLibs
            cpp.staticLibraries: staticLibs.concat("SDL2")

            cpp.libraryPaths: [project.buildDirectory, "../solid/lib/debug/darwin/x86_64"]
            cpp.includePaths: includePaths.concat("../solid/include/darwin")
            cpp.defines: project.defines.concat(project.sdlDefines)
        }

        Properties {
            condition: qbs.targetOS.contains("linux")

            //cpp.dynamicLibraries: linuxSharedLibs
            cpp.staticLibraries: staticLibs.concat("SDL2")

            cpp.libraryPaths: [project.buildDirectory, "../solid/lib/debug/linux/x86_64"]
            cpp.includePaths: includePaths.concat("../solid/include/linux")
            cpp.defines: project.defines.concat(project.sdlDefines)
        }

        Properties {
            condition: qbs.targetOS.contains("windows")

            cpp.dynamicLibraries: windowsSharedLibs
            cpp.staticLibraries: staticLibs

            cpp.libraryPaths: [project.buildDirectory, "../solid/lib/debug/mingw32/x86"]
            cpp.includePaths: includePaths.concat("../solid/include/mingw32")
            cpp.defines: project.defines.concat(project.windowsDefines)
        }

        Depends { name: "cpp" }
        Depends { name: "core" }
        Depends { name: "nullphysics" }
        Depends { name: "bulletphysics" }
    }
}
