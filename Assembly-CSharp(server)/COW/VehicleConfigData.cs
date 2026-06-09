using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200119D RID: 4509
	[Token(Token = "0x200119D")]
	public class VehicleConfigData
	{
		// Token: 0x0600462D RID: 17965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462D")]
		[Address(RVA = "0x1797920", Offset = "0x1797920", VA = "0x7BBBF97920")]
		public VehicleConfigData()
		{
		}

		// Token: 0x04005757 RID: 22359
		[Token(Token = "0x4005757")]
		[FieldOffset(Offset = "0x10")]
		public EControlMode ControlMode;

		// Token: 0x04005758 RID: 22360
		[Token(Token = "0x4005758")]
		[FieldOffset(Offset = "0x18")]
		public RigidBodyConfig RigidConfig;

		// Token: 0x04005759 RID: 22361
		[Token(Token = "0x4005759")]
		[FieldOffset(Offset = "0x20")]
		public VehicleParamConfig VehicleConfig;

		// Token: 0x0400575A RID: 22362
		[Token(Token = "0x400575A")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, VehicleControllerInfo> ControllerConfigs;
	}
}
