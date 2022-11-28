import { MDBRow } from "mdb-react-ui-kit";
import { GetServerSideProps } from "next";

type AthletesModel = {
    athletes: [
        {
            id: number;
            firstName: string;
            lastName: string;
        }
    ];
};

const Athletes = ({ athletes }: AthletesModel) => {
    return (
        <div>
            {athletes.map(({ firstName, lastName }, key) => (
                <MDBRow key={key}>
                    {firstName} {lastName}
                </MDBRow>
            ))}
        </div>
    );
};

export const getServerSideProps: GetServerSideProps = async (ctx) => {
    return {
        props: {
            athletes: null,
        },
    };
};

export default Athletes;
