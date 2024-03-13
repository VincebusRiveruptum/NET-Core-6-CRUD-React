import * as React from "react";
import styled from "styled-components";

function SvgComponent({logo}) {
  return (
    <ImageWrapper>
      <img src={logo} alt="Vincebus's logo"></img>
    </ImageWrapper>
  );
}

  const ImageWrapper = styled.div`
    display:flex;
    justify-content: center;
    padding:1%;
    img {
      width: 50%;
      height: auto;  
    }
  `;


export default SvgComponent;
