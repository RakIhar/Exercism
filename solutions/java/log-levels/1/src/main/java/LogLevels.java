public class LogLevels {
    
    public static String message(String logLine) {
        int logLevelIndex = logLine.indexOf("]");
        return logLine.substring(logLevelIndex + 2).trim();
    }

    public static String logLevel(String logLine) {
        int logLevelIndex = logLine.indexOf("]");
        return logLine.substring(1, logLevelIndex).toLowerCase();
    }

    public static String reformat(String logLine) {
        return message(logLine) + " (" + logLevel(logLine) + ")";
    }
}
