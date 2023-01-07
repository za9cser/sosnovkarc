import { MDBRow } from "mdb-react-ui-kit";
import { GetServerSideProps } from "next";
import athleteService from "../../crud/athletesCRUD";
import { AthletesModel } from "../../models/athletes/athlete";

const Athletes = ({ athletes }: AthletesModel) => {
    return (
        <>
            {athletes?.map(({ firstName, lastName }, key) => (
                <MDBRow key={key}>
                    {firstName} {lastName}
                </MDBRow>
            ))}
        </>
    );
};

export const getServerSideProps: GetServerSideProps = async (ctx) => {
    const result = await athleteService.getAthletes();

    return {
        props: {
            athletes: result.data,
        },
    };
};

export default Athletes;
