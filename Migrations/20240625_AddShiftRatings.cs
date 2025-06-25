public partial class AddShiftRatings : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "ShiftRatings",
            columns: table => new
            {
                ShiftId    = table.Column<int>(nullable: false),
                FacilityId = table.Column<int>(nullable: false),
                WorkerId   = table.Column<int>(nullable: false),
                Score      = table.Column<int>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ShiftRatings", x => new { x.ShiftId, x.WorkerId });
                table.ForeignKey("FK_ShiftRatings_Shifts_ShiftId",    x => x.ShiftId,    "Shifts",    "Id", onDelete: ReferentialAction.Cascade);
                table.ForeignKey("FK_ShiftRatings_Facilities_FacilityId", x => x.FacilityId, "Facilities", "Id", onDelete: ReferentialAction.Cascade);
                table.ForeignKey("FK_ShiftRatings_Workers_WorkerId",   x => x.WorkerId,   "Workers",   "Id", onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex("IX_ShiftRatings_FacilityId", "ShiftRatings", "FacilityId");
        migrationBuilder.CreateIndex("IX_ShiftRatings_WorkerId",   "ShiftRatings", "WorkerId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable("ShiftRatings");
    }
}