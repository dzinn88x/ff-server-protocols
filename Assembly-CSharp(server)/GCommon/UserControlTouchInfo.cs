using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EFC RID: 3836
	[Token(Token = "0x2000EFC")]
	public class UserControlTouchInfo
	{
		// Token: 0x060035CF RID: 13775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CF")]
		[Address(RVA = "0x2244778", Offset = "0x2244778", VA = "0x7BBCA44778")]
		public UserControlTouchInfo()
		{
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D0")]
		[Address(RVA = "0x2247CEC", Offset = "0x2247CEC", VA = "0x7BBCA47CEC")]
		public void Copy(UserControlTouchInfo t)
		{
		}

		// Token: 0x0400491A RID: 18714
		[Token(Token = "0x400491A")]
		[FieldOffset(Offset = "0x10")]
		public int TouchFinger;

		// Token: 0x0400491B RID: 18715
		[Token(Token = "0x400491B")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 TouchPosition;

		// Token: 0x0400491C RID: 18716
		[Token(Token = "0x400491C")]
		[FieldOffset(Offset = "0x20")]
		public TouchPhase TouchPhase;

		// Token: 0x0400491D RID: 18717
		[Token(Token = "0x400491D")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 DeltaPosition;
	}
}
