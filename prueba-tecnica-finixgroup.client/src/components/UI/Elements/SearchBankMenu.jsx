import React from 'react';
import styled from "styled-components";
import FullButton from '../Buttons/FullButton';
import { useSelector, useDispatch } from 'react-redux';
import { getByID, getByGUID } from '../../../store/bankSlice'; // Import your action creators
import { fetchBanksAsync } from '../../../store/bankSlice'; 

export default function SearchBankMenu({dispatch}) {
    
    const handleSearchSubmit = (event) => {
        event.preventDefault();

        

        const searchType = document.getElementById('searchBy').value;
        const idSearch = document.getElementById('searchInput').value;
   

        if (searchType === 'byId') {
            //Call store to show element by Id
            console.log("You are searching by ID:" + idSearch);
            dispatch(getByID(idSearch));

        } else {
            //Call store to show element by GUID
            console.log("You are searching by GUID:" + idSearch);
            dispatch(getByGUID(idSearch));
        }
    }
    return (
        <Wrapper className="container">
            <FormBox>
            
                    <FormTitle><h1 className='font30 semiBold'>Search by Id or GUID</h1></FormTitle>
                <BankForm onSubmit={handleSearchSubmit}>
                    <DropdownBox>
                        
                        <select className="font18" name="searchBy" id="searchBy">
                            <option value="byId">By ID</option>
                            <option value="byGuid">By GUID</option>
                        </select>
                    </DropdownBox>
                    <InputsBox>
                        <input className="font18" type="text" id="searchInput" name="searchInput" placeholder='Enter key here'required></input>
                    </InputsBox>
                    <ButtonBox>
                        <FullButton color="#ff1759" title="Search"></FullButton>
                    </ButtonBox>
                </BankForm>

            </FormBox>
            <hr></hr>
        </Wrapper>
    );
}

const Wrapper = styled.section`
  padding-top:5%;
`;

const FormTitle = styled.div`
text-align:center;
`;

const FormBox = styled.div`
  display:flex;
  flex-direction:column;
  justify-content:center;
    margin:2%;
`;

const DropdownBox = styled.div`
margin:2%;
display:flex;
flex-direction:row;
select{
    min-width:150px;
    text-align: center; 
}
`;
const InputsBox = styled.div`
margin:2%;
display:flex;
flex-direction:row;
input{
    min-width:250px;
    text-align: center; 
}

`;

const ButtonBox = styled.div`
margin:2%;
display:flex;
flex-direction:row;

`;


const BankForm = styled.form`
  display: flex;

  justify-content: center;

`;

