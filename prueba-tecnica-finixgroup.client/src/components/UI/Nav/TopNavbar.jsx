import { useEffect, useState } from "react";
import styled from "styled-components";
import { Routes, Route, Outlet, Link } from "react-router-dom";

export default function TopNavbar() {
  useEffect(() => {
    const handleScroll = () => {
      const navbar = document.getElementById("navbar");
      if (navbar) {
        if (window.scrollY > 100) {
          navbar.style.height = "60px";
        } else {
          navbar.style.height = "80px";
        }
      }
    };

    window.addEventListener("scroll", handleScroll);
    return () => {
      window.removeEventListener("scroll", handleScroll);
    };
  }, []);

  return (
    <Wrapper id="navbar" className="flexCenter animate grayBg">
      <NavInner className="container flexSpaceCenter">
        <Title className="font20 semiBold">
          Technical Evaluation Finix Group
        </Title>
        <UlWrapper className="flexNullCenter">
          <li className="semiBold font15 pointer">
            <Link style={{ padding: "10px 15px" }} to="home">
              Home
            </Link>
          </li>
          <li className="semiBold font15 pointer">
            <Link style={{ padding: "10px 15px" }} to="about">
              About
            </Link>
          </li>
        </UlWrapper>
      </NavInner>
    </Wrapper>
  );
}

const Wrapper = styled.nav`
  position: fixed;
  width: 100%;
  top: 0;
  left: 0;
  z-index: 9999;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.05), 0 6px 20px 0 rgba(0, 0, 0, 0.1);
`;

const NavInner = styled.div`

  position: relative;
  height: 100%;
`;

const UlWrapper = styled.ul`
  display: flex;
  @media (max-width: 760px) {
    display: none;
  }
`;

const Title = styled.div`
  display: flex;
  padding: 2%;
  width: 100%;
  @media (max-width: 760px) {
    justify-content: center;
  }
`;