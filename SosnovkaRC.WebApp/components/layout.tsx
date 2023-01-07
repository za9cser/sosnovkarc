import { MDBContainer } from "mdb-react-ui-kit";
import React from "react";

type Props = {
    children: React.ReactNode;
};

const Layout = ({ children }: Props) => {
    return <MDBContainer>{children}</MDBContainer>;
};

export default Layout;
