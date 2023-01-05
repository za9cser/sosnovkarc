import { MDBRow } from "mdb-react-ui-kit";
import { GetServerSideProps } from "next";
import athleteService from "../../crud/athletesCRUD";
import { AthletesModel } from "../../models/athletes/athlete";

const Athletes = ({ athletes }: AthletesModel) => {
    return (
        <div>
            {athletes?.map(({ firstName, lastName }, key) => (
                <MDBRow key={key}>
                    {firstName} {lastName}
                </MDBRow>
            ))}
        </div>
    );
};

export const getServerSideProps: GetServerSideProps = async (ctx) => {
    const result = await athleteService.getAthletes();

    console.log("data", result);
    return {
        props: {
            athletes: result.data,
        },
    };
};

export default Athletes;
