namespace DissidiaWebUI.Helpers
{
    public static class AttributeHelpers
    {
        public static string IsReadOnly(bool IsAuthenticated)
        {
            return IsAuthenticated ? "" : "readonly";
        }

        public static string IsDisabled(bool IsAuthenticated)
        {
            return IsAuthenticated ? "" : "disabled";
        }
    }
}
