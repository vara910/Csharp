import React from "react";
import { Particles } from "@tsparticles/react";
import { tsParticles } from "@tsparticles/engine";

const App = () => {
  const particlesInit = async (engine) => {
    console.log("Particles Loaded", engine);
  };

  return (
    <div className="relative h-screen w-full bg-gray-900 text-white">
      {/* Particles Background */}
      <Particles
        id="tsparticles"
        init={particlesInit}
        options={{
          background: { color: "#1a1a2e" },
          fpsLimit: 120,
          interactivity: {
            events: {
              onHover: { enable: true, mode: "repulse" },
            },
          },
          particles: {
            color: { value: "#ffffff" },
            links: { enable: true, distance: 150, color: "#ffffff" },
            move: { enable: true, speed: 2 },
            number: { value: 100 },
            opacity: { value: 0.5 },
            size: { value: 3 },
          },
        }}
      />

      {/* Main Content */}
      <div className="absolute inset-0 flex justify-center items-center">
        <h1 className="text-4xl font-bold">Welcome to SpotifyMoodMixer 🎵</h1>
      </div>
    </div>
  );
};

export default App;
