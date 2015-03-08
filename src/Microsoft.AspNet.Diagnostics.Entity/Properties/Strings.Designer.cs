﻿// <auto-generated />
namespace Microsoft.AspNet.Diagnostics.Entity
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Diagnostics.Entity.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// The string argument '{argumentName}' cannot be empty.
        /// </summary>
        internal static string ArgumentIsEmpty
        {
            get { return GetString("ArgumentIsEmpty"); }
        }

        /// <summary>
        /// The string argument '{argumentName}' cannot be empty.
        /// </summary>
        internal static string FormatArgumentIsEmpty(object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsEmpty", "argumentName"), argumentName);
        }

        /// <summary>
        /// The collection argument '{argumentName}' must contain at least one element.
        /// </summary>
        internal static string CollectionArgumentIsEmpty
        {
            get { return GetString("CollectionArgumentIsEmpty"); }
        }

        /// <summary>
        /// The collection argument '{argumentName}' must contain at least one element.
        /// </summary>
        internal static string FormatCollectionArgumentIsEmpty(object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CollectionArgumentIsEmpty", "argumentName"), argumentName);
        }

        /// <summary>
        /// The context type '{0}' was not found in services. This usually means the context was not registered in services during startup. You probably want to call AddScoped&lt;{0}&gt;() inside the UseServices(...) call in your application startup code. Skipping display of the database error page.
        /// </summary>
        internal static string DatabaseErrorPageMiddleware_ContextNotRegistered
        {
            get { return GetString("DatabaseErrorPageMiddleware_ContextNotRegistered"); }
        }

        /// <summary>
        /// The context type '{0}' was not found in services. This usually means the context was not registered in services during startup. You probably want to call AddScoped&lt;{0}&gt;() inside the UseServices(...) call in your application startup code. Skipping display of the database error page.
        /// </summary>
        internal static string FormatDatabaseErrorPageMiddleware_ContextNotRegistered(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DatabaseErrorPageMiddleware_ContextNotRegistered"), p0);
        }

        /// <summary>
        /// An exception occurred while calculating the database error page content. Skipping display of the database error page.
        /// </summary>
        internal static string DatabaseErrorPageMiddleware_Exception
        {
            get { return GetString("DatabaseErrorPageMiddleware_Exception"); }
        }

        /// <summary>
        /// An exception occurred while calculating the database error page content. Skipping display of the database error page.
        /// </summary>
        internal static string FormatDatabaseErrorPageMiddleware_Exception()
        {
            return GetString("DatabaseErrorPageMiddleware_Exception");
        }

        /// <summary>
        /// &gt; k ef migration add [migration name]
        /// </summary>
        internal static string DatabaseErrorPage_AddMigrationCommand
        {
            get { return GetString("DatabaseErrorPage_AddMigrationCommand"); }
        }

        /// <summary>
        /// &gt; k ef migration add [migration name]
        /// </summary>
        internal static string FormatDatabaseErrorPage_AddMigrationCommand()
        {
            return GetString("DatabaseErrorPage_AddMigrationCommand");
        }

        /// <summary>
        /// Apply Migrations
        /// </summary>
        internal static string DatabaseErrorPage_ApplyMigrationsButton
        {
            get { return GetString("DatabaseErrorPage_ApplyMigrationsButton"); }
        }

        /// <summary>
        /// Apply Migrations
        /// </summary>
        internal static string FormatDatabaseErrorPage_ApplyMigrationsButton()
        {
            return GetString("DatabaseErrorPage_ApplyMigrationsButton");
        }

        /// <summary>
        /// Migrations Applied
        /// </summary>
        internal static string DatabaseErrorPage_ApplyMigrationsButtonDone
        {
            get { return GetString("DatabaseErrorPage_ApplyMigrationsButtonDone"); }
        }

        /// <summary>
        /// Migrations Applied
        /// </summary>
        internal static string FormatDatabaseErrorPage_ApplyMigrationsButtonDone()
        {
            return GetString("DatabaseErrorPage_ApplyMigrationsButtonDone");
        }

        /// <summary>
        /// Applying Migrations...
        /// </summary>
        internal static string DatabaseErrorPage_ApplyMigrationsButtonRunning
        {
            get { return GetString("DatabaseErrorPage_ApplyMigrationsButtonRunning"); }
        }

        /// <summary>
        /// Applying Migrations...
        /// </summary>
        internal static string FormatDatabaseErrorPage_ApplyMigrationsButtonRunning()
        {
            return GetString("DatabaseErrorPage_ApplyMigrationsButtonRunning");
        }

        /// <summary>
        /// An error occurred applying migrations, try applying them from the command line
        /// </summary>
        internal static string DatabaseErrorPage_ApplyMigrationsFailed
        {
            get { return GetString("DatabaseErrorPage_ApplyMigrationsFailed"); }
        }

        /// <summary>
        /// An error occurred applying migrations, try applying them from the command line
        /// </summary>
        internal static string FormatDatabaseErrorPage_ApplyMigrationsFailed()
        {
            return GetString("DatabaseErrorPage_ApplyMigrationsFailed");
        }

        /// <summary>
        /// You can also apply migrations from the command line:
        /// </summary>
        internal static string DatabaseErrorPage_HowToApplyFromCmd
        {
            get { return GetString("DatabaseErrorPage_HowToApplyFromCmd"); }
        }

        /// <summary>
        /// You can also apply migrations from the command line:
        /// </summary>
        internal static string FormatDatabaseErrorPage_HowToApplyFromCmd()
        {
            return GetString("DatabaseErrorPage_HowToApplyFromCmd");
        }

        /// <summary>
        /// Try refreshing the page
        /// </summary>
        internal static string DatabaseErrorPage_MigrationsAppliedRefresh
        {
            get { return GetString("DatabaseErrorPage_MigrationsAppliedRefresh"); }
        }

        /// <summary>
        /// Try refreshing the page
        /// </summary>
        internal static string FormatDatabaseErrorPage_MigrationsAppliedRefresh()
        {
            return GetString("DatabaseErrorPage_MigrationsAppliedRefresh");
        }

        /// <summary>
        /// From the command line, scaffold a new migration and apply it to the database:
        /// </summary>
        internal static string DatabaseErrorPage_NoDbOrMigrationsInfo
        {
            get { return GetString("DatabaseErrorPage_NoDbOrMigrationsInfo"); }
        }

        /// <summary>
        /// From the command line, scaffold a new migration and apply it to the database:
        /// </summary>
        internal static string FormatDatabaseErrorPage_NoDbOrMigrationsInfo()
        {
            return GetString("DatabaseErrorPage_NoDbOrMigrationsInfo");
        }

        /// <summary>
        /// Use migrations to create the database for {0}
        /// </summary>
        internal static string DatabaseErrorPage_NoDbOrMigrationsTitle
        {
            get { return GetString("DatabaseErrorPage_NoDbOrMigrationsTitle"); }
        }

        /// <summary>
        /// Use migrations to create the database for {0}
        /// </summary>
        internal static string FormatDatabaseErrorPage_NoDbOrMigrationsTitle(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DatabaseErrorPage_NoDbOrMigrationsTitle"), p0);
        }

        /// <summary>
        /// Scaffold a new migration for these changes and apply them to the database from the command line:
        /// </summary>
        internal static string DatabaseErrorPage_PendingChangesInfo
        {
            get { return GetString("DatabaseErrorPage_PendingChangesInfo"); }
        }

        /// <summary>
        /// Scaffold a new migration for these changes and apply them to the database from the command line:
        /// </summary>
        internal static string FormatDatabaseErrorPage_PendingChangesInfo()
        {
            return GetString("DatabaseErrorPage_PendingChangesInfo");
        }

        /// <summary>
        /// There are pending model changes for {0}
        /// </summary>
        internal static string DatabaseErrorPage_PendingChangesTitle
        {
            get { return GetString("DatabaseErrorPage_PendingChangesTitle"); }
        }

        /// <summary>
        /// There are pending model changes for {0}
        /// </summary>
        internal static string FormatDatabaseErrorPage_PendingChangesTitle(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DatabaseErrorPage_PendingChangesTitle"), p0);
        }

        /// <summary>
        /// There are migrations for {0} that have not been applied to the database
        /// </summary>
        internal static string DatabaseErrorPage_PendingMigrationsInfo
        {
            get { return GetString("DatabaseErrorPage_PendingMigrationsInfo"); }
        }

        /// <summary>
        /// There are migrations for {0} that have not been applied to the database
        /// </summary>
        internal static string FormatDatabaseErrorPage_PendingMigrationsInfo(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DatabaseErrorPage_PendingMigrationsInfo"), p0);
        }

        /// <summary>
        /// Applying existing migrations for {0} may resolve this issue
        /// </summary>
        internal static string DatabaseErrorPage_PendingMigrationsTitle
        {
            get { return GetString("DatabaseErrorPage_PendingMigrationsTitle"); }
        }

        /// <summary>
        /// Applying existing migrations for {0} may resolve this issue
        /// </summary>
        internal static string FormatDatabaseErrorPage_PendingMigrationsTitle(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DatabaseErrorPage_PendingMigrationsTitle"), p0);
        }

        /// <summary>
        /// &gt; k ef migration apply
        /// </summary>
        internal static string DatabaseErrorPage_ApplyMigrationsCommand
        {
            get { return GetString("DatabaseErrorPage_ApplyMigrationsCommand"); }
        }

        /// <summary>
        /// &gt; k ef migration apply
        /// </summary>
        internal static string FormatDatabaseErrorPage_ApplyMigrationsCommand()
        {
            return GetString("DatabaseErrorPage_ApplyMigrationsCommand");
        }

        /// <summary>
        /// The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        internal static string InvalidEnumValue
        {
            get { return GetString("InvalidEnumValue"); }
        }

        /// <summary>
        /// The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        internal static string FormatInvalidEnumValue(object argumentName, object enumType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidEnumValue", "argumentName", "enumType"), argumentName, enumType);
        }

        /// <summary>
        /// Migrations successfully applied for context '{0}'.
        /// </summary>
        internal static string MigrationsEndPointMiddleware_Applied
        {
            get { return GetString("MigrationsEndPointMiddleware_Applied"); }
        }

        /// <summary>
        /// Migrations successfully applied for context '{0}'.
        /// </summary>
        internal static string FormatMigrationsEndPointMiddleware_Applied(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigrationsEndPointMiddleware_Applied"), p0);
        }

        /// <summary>
        /// Request is valid, applying migrations for context '{0}'.
        /// </summary>
        internal static string MigrationsEndPointMiddleware_ApplyingMigrations
        {
            get { return GetString("MigrationsEndPointMiddleware_ApplyingMigrations"); }
        }

        /// <summary>
        /// Request is valid, applying migrations for context '{0}'.
        /// </summary>
        internal static string FormatMigrationsEndPointMiddleware_ApplyingMigrations(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigrationsEndPointMiddleware_ApplyingMigrations"), p0);
        }

        /// <summary>
        /// The context type '{0}' was not found in services. This usually means the context was not registered in services during startup. You probably want to call AddScoped&lt;{0}&gt;() inside the UseServices(...) call in your application startup code.
        /// </summary>
        internal static string MigrationsEndPointMiddleware_ContextNotRegistered
        {
            get { return GetString("MigrationsEndPointMiddleware_ContextNotRegistered"); }
        }

        /// <summary>
        /// The context type '{0}' was not found in services. This usually means the context was not registered in services during startup. You probably want to call AddScoped&lt;{0}&gt;() inside the UseServices(...) call in your application startup code.
        /// </summary>
        internal static string FormatMigrationsEndPointMiddleware_ContextNotRegistered(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigrationsEndPointMiddleware_ContextNotRegistered"), p0);
        }

        /// <summary>
        /// An error occurred while applying the migrations for '{0}'. See InnerException for details.
        /// </summary>
        internal static string MigrationsEndPointMiddleware_Exception
        {
            get { return GetString("MigrationsEndPointMiddleware_Exception"); }
        }

        /// <summary>
        /// An error occurred while applying the migrations for '{0}'. See InnerException for details.
        /// </summary>
        internal static string FormatMigrationsEndPointMiddleware_Exception(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigrationsEndPointMiddleware_Exception"), p0);
        }

        /// <summary>
        /// The context type '{0}' could not be loaded. Ensure this is the correct type name for the context you are trying to apply migrations for.
        /// </summary>
        internal static string MigrationsEndPointMiddleware_InvalidContextType
        {
            get { return GetString("MigrationsEndPointMiddleware_InvalidContextType"); }
        }

        /// <summary>
        /// The context type '{0}' could not be loaded. Ensure this is the correct type name for the context you are trying to apply migrations for.
        /// </summary>
        internal static string FormatMigrationsEndPointMiddleware_InvalidContextType(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigrationsEndPointMiddleware_InvalidContextType"), p0);
        }

        /// <summary>
        /// No context type was specified. Ensure the form data from the request includes a contextTypeName value, specifying the context to apply migrations for.
        /// </summary>
        internal static string MigrationsEndPointMiddleware_NoContextType
        {
            get { return GetString("MigrationsEndPointMiddleware_NoContextType"); }
        }

        /// <summary>
        /// No context type was specified. Ensure the form data from the request includes a contextTypeName value, specifying the context to apply migrations for.
        /// </summary>
        internal static string FormatMigrationsEndPointMiddleware_NoContextType()
        {
            return GetString("MigrationsEndPointMiddleware_NoContextType");
        }

        /// <summary>
        /// Request path matched the path configured for this migrations endpoint ({0}). Attempting to process the migrations request.
        /// </summary>
        internal static string MigrationsEndPointMiddleware_RequestPathMatched
        {
            get { return GetString("MigrationsEndPointMiddleware_RequestPathMatched"); }
        }

        /// <summary>
        /// Request path matched the path configured for this migrations endpoint ({0}). Attempting to process the migrations request.
        /// </summary>
        internal static string FormatMigrationsEndPointMiddleware_RequestPathMatched(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigrationsEndPointMiddleware_RequestPathMatched"), p0);
        }

        /// <summary>
        /// A database operation failed while processing the request.
        /// </summary>
        internal static string DatabaseErrorPage_Title
        {
            get { return GetString("DatabaseErrorPage_Title"); }
        }

        /// <summary>
        /// A database operation failed while processing the request.
        /// </summary>
        internal static string FormatDatabaseErrorPage_Title()
        {
            return GetString("DatabaseErrorPage_Title");
        }

        /// <summary>
        /// To use migrations from a command prompt you will need to &lt;a href='http://go.microsoft.com/fwlink/?LinkId=518242'&gt;install K Version Manager (DNVM)&lt;/a&gt;. Once installed, you can run migration commands from a standard command prompt in the project directory.
        /// </summary>
        internal static string DatabaseErrorPage_EnableMigrationsCommandsInfo
        {
            get { return GetString("DatabaseErrorPage_EnableMigrationsCommandsInfo"); }
        }

        /// <summary>
        /// To use migrations from a command prompt you will need to &lt;a href='http://go.microsoft.com/fwlink/?LinkId=518242'&gt;install K Version Manager (DNVM)&lt;/a&gt;. Once installed, you can run migration commands from a standard command prompt in the project directory.
        /// </summary>
        internal static string FormatDatabaseErrorPage_EnableMigrationsCommandsInfo()
        {
            return GetString("DatabaseErrorPage_EnableMigrationsCommandsInfo");
        }

        /// <summary>
        /// {0} occurred, checking if Entity Framework recorded this exception as resulting from a failed database operation.
        /// </summary>
        internal static string DatabaseErrorPage_AttemptingToMatchException
        {
            get { return GetString("DatabaseErrorPage_AttemptingToMatchException"); }
        }

        /// <summary>
        /// {0} occurred, checking if Entity Framework recorded this exception as resulting from a failed database operation.
        /// </summary>
        internal static string FormatDatabaseErrorPage_AttemptingToMatchException(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DatabaseErrorPage_AttemptingToMatchException"), p0);
        }

        /// <summary>
        /// Entity Framework recorded that the current exception was due to a failed database operation. Attempting to show database error page.
        /// </summary>
        internal static string DatabaseErrorPage_Matched
        {
            get { return GetString("DatabaseErrorPage_Matched"); }
        }

        /// <summary>
        /// Entity Framework recorded that the current exception was due to a failed database operation. Attempting to show database error page.
        /// </summary>
        internal static string FormatDatabaseErrorPage_Matched()
        {
            return GetString("DatabaseErrorPage_Matched");
        }

        /// <summary>
        /// Entity Framework did not record any exceptions due to failed database operations. This means the current exception is not a failed Entity Framework database operation, or the current exception occurred from a DbContext that was not obtained from request services.
        /// </summary>
        internal static string DatabaseErrorPage_NoRecordedException
        {
            get { return GetString("DatabaseErrorPage_NoRecordedException"); }
        }

        /// <summary>
        /// Entity Framework did not record any exceptions due to failed database operations. This means the current exception is not a failed Entity Framework database operation, or the current exception occurred from a DbContext that was not obtained from request services.
        /// </summary>
        internal static string FormatDatabaseErrorPage_NoRecordedException()
        {
            return GetString("DatabaseErrorPage_NoRecordedException");
        }

        /// <summary>
        /// The target data store is not a relational database. Skipping the database error page.
        /// </summary>
        internal static string DatabaseErrorPage_NotRelationalDatabase
        {
            get { return GetString("DatabaseErrorPage_NotRelationalDatabase"); }
        }

        /// <summary>
        /// The target data store is not a relational database. Skipping the database error page.
        /// </summary>
        internal static string FormatDatabaseErrorPage_NotRelationalDatabase()
        {
            return GetString("DatabaseErrorPage_NotRelationalDatabase");
        }

        /// <summary>
        /// The current exception (and its inner exceptions) do not match the last exception Entity Framework recorded due to a failed database operation. This means the database operation exception was handled and another exception occurred later in the request.
        /// </summary>
        internal static string DatabaseErrorPage_NoMatch
        {
            get { return GetString("DatabaseErrorPage_NoMatch"); }
        }

        /// <summary>
        /// The current exception (and its inner exceptions) do not match the last exception Entity Framework recorded due to a failed database operation. This means the database operation exception was handled and another exception occurred later in the request.
        /// </summary>
        internal static string FormatDatabaseErrorPage_NoMatch()
        {
            return GetString("DatabaseErrorPage_NoMatch");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
