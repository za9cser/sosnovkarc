import React from "react";
import { useMediaQuery } from "react-responsive";

type Props = {
    children: React.ReactNode;
};

export const Desktop = ({ children }: Props) => {
    const isDesktop = useMediaQuery({ minWidth: 992 });
    return isDesktop ? <>{children}</> : null;
};

export const Mobile = ({ children }: Props) => {
    const isMobile = useMediaQuery({ maxWidth: 992 });
    return isMobile ? <>{children}</> : null;
};
