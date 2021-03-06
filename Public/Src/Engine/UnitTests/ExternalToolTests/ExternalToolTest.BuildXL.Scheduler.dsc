// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

import * as Managed from "Sdk.Managed";
import * as Deployment from "Sdk.Deployment";

namespace ExternalToolTest {
    export declare const qualifier : BuildXLSdk.DefaultQualifier;

    @@public
    export const dll = BuildXLSdk.test({
        // These tests require Detours to run itself, so we can't detour xunit itself
        // TODO: QTest
        testFramework: importFrom("Sdk.Managed.Testing.XUnit.UnsafeUnDetoured").framework,

        assemblyName: "ExternalToolTest.BuildXL.Scheduler",
        sources: globR(d`.`, "*.cs"),
        references: [
            Scheduler.dll,
            EngineTestUtilities.dll,
            Scheduler.IntegrationTest.dll,
            importFrom("BuildXL.Engine").Scheduler.dll,
            importFrom("BuildXL.Pips").dll,
            importFrom("BuildXL.Utilities").dll,
            importFrom("BuildXL.Utilities").Collections.dll,
            importFrom("BuildXL.Utilities").Configuration.dll,
            importFrom("BuildXL.Utilities").Native.dll,
            importFrom("BuildXL.Utilities.UnitTests").TestProcess.exe,
        ],
        runtimeContent: [
            importFrom("BuildXL.Utilities.UnitTests").TestProcess.deploymentDefinition,
            importFrom("BuildXL.Tools").SandboxedProcessExecutor.exe,
            // TODO: Move it to the root when we can access the real VmCommandProxy in CB.
            {
                subfolder: r`tools/VmCommandProxy/tools`,
                contents: [
                    importFrom("BuildXL.Utilities.UnitTests").MockVmCommandProxy.exe
                ]
            }
        ],
    });
}
