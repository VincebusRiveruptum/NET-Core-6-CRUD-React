import React, { useState } from "react";
import styled from "styled-components";
import FullButton from "../Buttons/FullButton";
import ModifyModal from "./ModifyModal";
import RemoveBankModal from "./RemoveBankModal";

export default function BankListTable({ bankList }) {
  const itemsPerPage = 10;
  const [currentPage, setCurrentPage] = useState(1);
  const [visibleRemoveModalForBank, setVisibleRemoveModalForBank] =
    useState(null);
  const [visibleModifyModalForBank, setVisibleModifyModalForBank] =
    useState(null);

  const indexOfLastItem = currentPage * itemsPerPage;
  const indexOfFirstItem = indexOfLastItem - itemsPerPage;
  const currentItems = bankList.slice(indexOfFirstItem, indexOfLastItem);

  const totalPages = Math.ceil(bankList.length / itemsPerPage);

  const handleRemove = (bank) => {
    setVisibleRemoveModalForBank(bank.id);
  };

  const handleModify = (bank) => {
    setVisibleRemoveModalForBank(bank.id);
  };

  return (
    <Wrapper className="container font14">
      {currentItems.length ? (
        <>
          <TableBox>
            <Table>
              <thead>
                <tr>
                  <th>ID</th>
                  <th>Bank Name</th>
                  <th>Action</th>
                </tr>
              </thead>
              <tbody>
                {currentItems.map((bank) => (
                  <tr key={bank.id}>
                    <td>{bank.id}</td>
                    <td>{bank.bank_name}</td>
                    <td>
                      <FullButton
                        action={() => handleRemove(bank)}
                        color="#ff1759"
                        title="Remove"
                      ></FullButton>
                      <FullButton
                        action={() => handleModify(bank)}
                        color="#ff1759"
                        title="Modify"
                      ></FullButton>
                      {visibleModifyModalForBank === bank.id ? (
                        <ModifyModal
                          onClose={() => setVisibleModifyModalForBank(null)}
                          bankItem={bank}
                        />
                      ) : (
                        ""
                      )}
                      {visibleRemoveModalForBank === bank.id ? (
                        <RemoveBankModal
                          onClose={() => setVisibleRemoveModalForBank(null)}
                          bankItem={bank}
                        />
                      ) : (
                        ""
                      )}
                    </td>
                  </tr>
                ))}
              </tbody>
            </Table>
          </TableBox>
          <PaginationBox>
            <Pagination>
              <ButtonsBox>
                <FullButton
                  action={() => setCurrentPage(currentPage - 1)}
                  disabled={currentPage === 1}
                  color="#ff1759"
                  title="Previous Page"
                ></FullButton>

                <FullButton
                  action={() => setCurrentPage(currentPage + 1)}
                  disabled={currentPage === totalPages}
                  color="#ff1759"
                  title="Next Page"
                ></FullButton>
              </ButtonsBox>
              <Title>
                <span className="font16 semiBold">
                  {currentPage} - {totalPages}
                </span>
              </Title>
              <Title className="font18 semiBold">
                Showing {currentItems.length} results of {bankList.length}
              </Title>
            </Pagination>
          </PaginationBox>
        </>
      ) : (
        <Title className="font30 extraBold">No results</Title>
      )}
    </Wrapper>
  );
}

const Wrapper = styled.div`
  display: flex;
  justify-content: center;
  flex-direction: column;
  width: 100%;
  padding: 2%;
`;

const Table = styled.table`
  width: 100%;
`;

const Title = styled.div`
  display: flex;
  justify-content: center;
  @media (max-width: 760px) {
    justify-content: center;
  }
`;
const TableBox = styled.div`
  padding-bottom: 5%;
`;

const PaginationBox = styled.div`
  display: flex;
  justify-content: center;
  flex-direction: column;
  padding: 2%;
`;
const ButtonsBox = styled.div`
  display: flex;
  justify-content: center;
  margin:auto;
  width:50%;
  padding: 2%;
  
`;
const Pagination = styled.div`
  display: flex;
  justify-content: center;
  flex-direction: column;
`;
