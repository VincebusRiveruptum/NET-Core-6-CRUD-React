import React from "react";
import styled from "styled-components";

function darkerColor(color){
  // Remove the "#" if present
  let hexColor = color.replace("#", "");
  let amount = 45;

  // Convert the hex color to decimal
  const decimalColor = parseInt(hexColor, 16);

  // Extract the red, green, and blue components
  let r = (decimalColor >> 16) + amount;
  let g = ((decimalColor >> 8) & 0x00FF) + amount;
  let b = (decimalColor & 0x0000FF) + amount;

  // Ensure the values are within the valid range (0-255)
  r = Math.min(255, Math.max(0, r));
  g = Math.min(255, Math.max(0, g));
  b = Math.min(255, Math.max(0, b));

  // Combine the components and convert back to hex
  const newColor = (r << 16) | (g << 8) | b;
  return "#" + newColor.toString(16);
}

export default function FullButton({ title, action, border, color, type, form, value, className}) {
  return (
    <Wrapper border={border} color={color}>
      <button
        className={className ? className : "animate pointer radius6" }    // Default className
        onClick={action}
        type={type}
        form={form}
        value={value}
      >        
        {value ? value : title}
      </button>
    </Wrapper>
  );
}

const Wrapper = styled.div`
margin: 0 auto;
padding:1%;
  button{
    border: 1px solid ${(props) => (props.border ? "#707070" : props.color)};
    background-color: ${(props) => (props.border ? "transparent" : props.color)};
    width: 100%;
    padding: 15px;
    outline: none;
    color: ${(props) => (props.border ? "#707070" : "#fff")};
    
  }
  button:hover {
    background-color: ${(props) => (props.border ? "transparent" : darkerColor(props.color))};
    border: 1px solid darkerColor(props.color);
    color: ${(props) => (props.border ? "#7620ff" : "#fff")};
  }
  
  @media (max-width: 760px) {

  }
`;
