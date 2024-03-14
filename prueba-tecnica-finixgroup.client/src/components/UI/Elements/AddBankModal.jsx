import React, {useState} from 'react';
import styled from 'styled-components';

import {addBank, generateUUID} from "../../../store/apiServices";

export default function AddBankModal({ onClose }) {
    const [responseMessage, setResponseMessage] = useState(null);

    const onAdd = (e) => {
        e.preventDefault();
        let id = document.getElementById("idInput").value;
        let newName = document.getElementById("nameInput").value;
        let request = { id: id, guid: generateUUID(), iban: Math.random().toString(), bank_name: newName, routing_number: Math.random().toString(), swift_bic: Math.random().toString() };

        addBank(request)
            .then((response) => {
                console.log(response);
                setResponseMessage("Bank added successfully!");
                // wait at least one second so the confirmation can be readable
                setTimeout(() => {
                    window.location.reload();
                }, 1000);
            })
            .catch((error) => {
                console.error('Error adding bank:', error);
                setResponseMessage("Error adding bank! : " + error.message);
            });
    };

    return (
        <ModalOverlay>
            <ModalContent>
                <h2>Add new bank</h2>
                <AddInput>
                    <input className="font18" type="text" placeholder="ID" id="idInput" required />
                    <input className="font18" type="text" placeholder="New bank name" id="nameInput" required />
                </AddInput>
                {responseMessage && <ResponseLabel success={!responseMessage.startsWith('Error')}>{responseMessage}</ResponseLabel>}
                <hr />
                <ModalFooter>
                    <Button onClick={onClose}>Cancel</Button>
                    <Button onClick={(e) => onAdd(e)}>Add</Button>
                </ModalFooter>
            </ModalContent>
        </ModalOverlay>
    );
}

const AddInput = styled.div`
    padding-top:5%;
    
    input{
        margin-bottom:3%;
        min-width:250px;
        text-align: center; 
    }
`;
const ModalOverlay = styled.div`
position: fixed;
top: 0;
left: 0;
width: 100%;
height: 100%;
background-color: rgba(0, 0, 0, 0.01);
display: flex;
justify-content: center;
align-items: center;
z-index: 999;
`;

const ModalContent = styled.div`
background-color: white;
padding: 20px;
border-radius: 4px;
animation: slideIn 0.3s ease-out forwards;
transform: translateY(100%);
@keyframes slideIn {
    from {
        transform: translateY(100%);
    }
    to {
        transform: translateY(0);
    }
}
`;

const ResponseLabel = styled.p`
    color: ${({ success }) => (success ? 'green' : 'red')};
`;


const ModalFooter = styled.div`
background-color: white;
text-align:center;
`;

const Button = styled.button`

margin: 10px;
padding: 8px 16px;
background-color: #505050;
color: white;
border: none;
border-radius: 4px;
cursor: pointer;
`;