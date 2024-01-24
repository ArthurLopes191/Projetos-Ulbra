import React from "react";
import Avatar from "./Avatar";

function Profile({ nome, profissao, premios, descobertas, srcImg }) {
  return (
    <div
      style={{
        border: "1px solid black",
        borderRadius: "5px",
        padding: "15px",
        margin: "10px",
      }}
    >
      <h1>{nome}</h1>
      <Avatar srcImage={srcImg} size={100} />
      <ul>
        <li>
          <b>Profession:</b>
          {profissao}
        </li>
        <li>
          <b>Awards:</b>
          {premios}
        </li>
        <li>
          <b>Discovereds:</b>
          {descobertas}
        </li>
      </ul>
    </div>
  );
}

export default Profile;
