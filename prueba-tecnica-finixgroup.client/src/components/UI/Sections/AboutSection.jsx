import React from "react";
import { useState, useEffect } from "react";
import styled from "styled-components";
import { Link } from "react-scroll";
import { useSelector, useDispatch } from "react-redux";
import { fetchBanksAsync } from "../../../store/bankSlice";
import BankListTable from "../Elements/BankListTable";
import SearchBankMenu from "../Elements/SearchBankMenu";
import ApiTestingControl from "../Elements/ApiTestingControl";

export default function AboutSection() {
  return (
    <Wrapper className="lightBg">
      <AboutBox>
        <Title>
          <h1 className="font30 semiBold">About this app</h1>
          <p className="font14">
            This technical test was made by Vicente Riveros Garay using the
            following stack:
          </p>
          <p className="font14">
            <br />
            <h1 className="font20 semiBold">Back End</h1>
            <li>
              ASP.NET Core 6.0 with Entity Framework ORM for interaction with the
              database and controllers.
            </li>
            <li>
              HttpClass for to the random API connection: This library was
              chosen because it is the most common
              and recommended by Microsoft.
            </li>
            <li>
              Swagger for documenting API methods: Swagger came with the Visual
              Studio Community React + ASP Net Core template, so it was very
              straightforward to use and no implementation necessesary at all.
            </li>
            <li>
              SQLite for the database engine, along with DB Browser to visualize
              database changes.
            </li>
            <br />
            <h1 className="font20 semiBold">Front End</h1>
            <li>React + Redux and Axios for API connection.</li>
            <li>
              Styled Components for app styling, this library was chosen because i consider it the easiest and fastest to handle.
            </li>
            <br />
            <h1 className="font20 semiBold">IDE</h1>
            <li>Visual Studio Community</li>
            <li>Visual Studio Code</li>

            <br />
          </p>
          <p className="font14">
          The app is completely programmed in English and contains some
          comments. To run the project, you need to install dependencies for
          both client and server code, simply use npm i and dotnet restore,
          respectively. Seeding is done during the first migration; however, the
          db file is attached in case of any issues. Made by
          </p>
        </Title>
        <ApiTestingControl/>
      </AboutBox>
    </Wrapper>
  );
}

const Wrapper = styled.section`
  display: flex;
  justify-content: center;
  flex-direction: column;
  width: 100%;
  padding: 2% 0; /* Add vertical padding */
  margin-top: 80px; /* Adjust for the maximum height of your navbar */
`;

const AboutBox = styled.div`
  display: inline-block;
  padding: 2%;
  flex-direction: column;
  justify-content: center;
  @media (max-width: 760px) {
  }
`;

const Title = styled.div`
  display: inline-block;
  padding: 2%;
  @media (max-width: 760px) {
    justify-content: center;
  }
`;
