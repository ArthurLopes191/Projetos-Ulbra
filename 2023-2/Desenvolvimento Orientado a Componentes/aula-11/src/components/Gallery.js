import React from "react";
import Profile from "./Profile";

function Gallery({ titulo }) {
  return (
    <div>
      <h1 style={{ marginLeft: "10px" }}>{titulo}</h1>
      <Profile
        nome="Maria Sklodowska-Curie"
        profissao="physicist and chemist"
        premios="4 (Nobel Prize in Physics, Nobel Prize in CHemistry, Davy Medal, Matteucci Medal)"
        descobertas="polonium (chemical element)"
        srcImg="https://i.imgur.com/szV5sdG.jpeg"
      />
      <Profile
        nome="Katsuko Saruhashi"
        profissao="pgeochemist"
        premios="2 (Miyake Prize for geochemistry, Tanaka Prize)"
        descobertas="a method for measuring carbon dioxide in seawater"
        srcImg="https://i.imgur.com/YfeOqp2.jpeg"
      />
    </div>
  );
}

export default Gallery;
