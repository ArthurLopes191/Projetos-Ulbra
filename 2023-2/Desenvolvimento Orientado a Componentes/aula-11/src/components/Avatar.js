import React from "react";

function Avatar({ srcImage, size }) {
  return (
    <img
      src={srcImage}
      style={{ borderRadius: "50%" }}
      width={size}
      height={size}
      alt="imagem pessoa"
    />
  );
}

export default Avatar;
