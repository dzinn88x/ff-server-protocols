using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200119E RID: 4510
	[Token(Token = "0x200119E")]
	public class VehicleConfigDataMap
	{
		// Token: 0x0600462E RID: 17966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462E")]
		[Address(RVA = "0x17981C4", Offset = "0x17981C4", VA = "0x7BBBF981C4")]
		public VehicleConfigDataMap()
		{
		}

		// Token: 0x0400575B RID: 22363
		[Token(Token = "0x400575B")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, VehicleConfigData> Vehicles;
	}
}
