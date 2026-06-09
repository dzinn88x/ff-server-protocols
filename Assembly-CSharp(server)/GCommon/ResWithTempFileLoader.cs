using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FCC RID: 4044
	[Token(Token = "0x2000FCC")]
	public class ResWithTempFileLoader : ResWithTimeoutFileLoader
	{
		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06003B2B RID: 15147 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x170006F3")]
		public virtual long CELL_SIZE
		{
			[Token(Token = "0x6003B2B")]
			[Address(RVA = "0x248197C", Offset = "0x248197C", VA = "0x7BBCC8197C", Slot = "14")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F4")]
		public string ResFileHash
		{
			[Token(Token = "0x6003B2C")]
			[Address(RVA = "0x2481984", Offset = "0x2481984", VA = "0x7BBCC81984")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x000126C0 File Offset: 0x000108C0
		[Token(Token = "0x170006F5")]
		public ResFileType FileType
		{
			[Token(Token = "0x6003B2D")]
			[Address(RVA = "0x24819B0", Offset = "0x24819B0", VA = "0x7BBCC819B0")]
			get
			{
				return ResFileType.Compulsory;
			}
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2E")]
		[Address(RVA = "0x24819DC", Offset = "0x24819DC", VA = "0x7BBCC819DC")]
		public ResWithTempFileLoader()
		{
		}

		// Token: 0x04004CAA RID: 19626
		[Token(Token = "0x4004CAA")]
		[FieldOffset(Offset = "0x50")]
		public string TempPath;

		// Token: 0x04004CAB RID: 19627
		[Token(Token = "0x4004CAB")]
		[FieldOffset(Offset = "0x58")]
		public string TempFileHash;

		// Token: 0x04004CAC RID: 19628
		[Token(Token = "0x4004CAC")]
		[FieldOffset(Offset = "0x60")]
		public string FlagPath;
	}
}
