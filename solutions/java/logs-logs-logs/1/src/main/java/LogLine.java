public class LogLine {
    private final String logLine;

    public LogLine(String logLine) {
        this.logLine = logLine;
    }

    public LogLevel getLogLevel() {
        return LogLevel.getLogLevel(logLine);
    }

    public String getOutputForShortLog() {
        LogLevel level = LogLevel.getLogLevel(logLine);

        int code = level.getLevelCode();

        String message = logLine.substring(logLine.indexOf(":") + 1).trim();

        return code + ":" + message;
    }
}
