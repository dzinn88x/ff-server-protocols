using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200119C RID: 4508
	[Token(Token = "0x200119C")]
	public class VehicleParamConfig
	{
		// Token: 0x0600462C RID: 17964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462C")]
		[Address(RVA = "0x17981CC", Offset = "0x17981CC", VA = "0x7BBBF981CC")]
		public VehicleParamConfig()
		{
		}

		// Token: 0x04005755 RID: 22357
		[Token(Token = "0x4005755")]
		[FieldOffset(Offset = "0x10")]
		public VehicleConfig.CarCrashParam CrashParam;

		// Token: 0x04005756 RID: 22358
		[Token(Token = "0x4005756")]
		[FieldOffset(Offset = "0x18")]
		public VehicleConfig.CarExplodeParam ExplodeParam;
	}
}
