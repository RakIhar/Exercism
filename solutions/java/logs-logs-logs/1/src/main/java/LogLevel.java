public enum LogLevel {
    TRACE(1),
    DEBUG(2),
    INFO(4),
    WARNING(5),
    ERROR(6),
    FATAL(42),
    UNKNOWN(0);

    private final int levelCode;

    LogLevel(int levelCode) {
        this.levelCode = levelCode;
    }

    public int getLevelCode() {
        return levelCode;
    }

    static LogLevel getLogLevel(String msg) {
        if (msg == null || msg.length() < 4)
            return LogLevel.UNKNOWN;

        String level = msg.substring(1, 4);

        return switch (level) {
            case "TRC" -> LogLevel.TRACE;
            case "DBG" -> LogLevel.DEBUG;
            case "INF" -> LogLevel.INFO;
            case "WRN" -> LogLevel.WARNING;
            case "ERR" -> LogLevel.ERROR;
            case "FTL" -> LogLevel.FATAL;
            default    -> LogLevel.UNKNOWN;
        };
    }
}