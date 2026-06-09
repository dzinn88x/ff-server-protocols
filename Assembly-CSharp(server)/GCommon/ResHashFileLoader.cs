using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FCF RID: 4047
	[Token(Token = "0x2000FCF")]
	public class ResHashFileLoader : ResFileLoader
	{
		// Token: 0x06003B49 RID: 15177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B49")]
		[Address(RVA = "0x296358C", Offset = "0x296358C", VA = "0x7BBD16358C", Slot = "7")]
		protected override void OnStart(float time)
		{
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00012798 File Offset: 0x00010998
		[Token(Token = "0x6003B4A")]
		[Address(RVA = "0x2963758", Offset = "0x2963758", VA = "0x7BBD163758", Slot = "10")]
		public override bool HasStarted()
		{
			return default(bool);
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x000127B0 File Offset: 0x000109B0
		[Token(Token = "0x6003B4B")]
		[Address(RVA = "0x2963768", Offset = "0x2963768", VA = "0x7BBD163768", Slot = "6")]
		public override bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4C")]
		[Address(RVA = "0x2963770", Offset = "0x2963770", VA = "0x7BBD163770", Slot = "11")]
		protected override void OnUpdate(float time)
		{
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4D")]
		[Address(RVA = "0x2963BD4", Offset = "0x2963BD4", VA = "0x7BBD163BD4", Slot = "9")]
		protected override void OnNotify()
		{
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4E")]
		[Address(RVA = "0x2963CD4", Offset = "0x2963CD4", VA = "0x7BBD163CD4", Slot = "8")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x000127C8 File Offset: 0x000109C8
		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x2963D68", Offset = "0x2963D68", VA = "0x7BBD163D68", Slot = "5")]
		public override bool IsTimeout(float time)
		{
			return default(bool);
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x2963D1C", Offset = "0x2963D1C", VA = "0x7BBD163D1C")]
		public void CloseInput()
		{
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x2963D38", Offset = "0x2963D38", VA = "0x7BBD163D38")]
		private void ClearHashWorker()
		{
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x2963D70", Offset = "0x2963D70", VA = "0x7BBD163D70")]
		public ResHashFileLoader()
		{
		}

		// Token: 0x04004CC1 RID: 19649
		[Token(Token = "0x4004CC1")]
		[FieldOffset(Offset = "0x48")]
		public Action<string, ResHashFileLoader> OnLoaded;

		// Token: 0x04004CC2 RID: 19650
		[Token(Token = "0x4004CC2")]
		[FieldOffset(Offset = "0x50")]
		private FileStream m_FileStream;

		// Token: 0x04004CC3 RID: 19651
		[Token(Token = "0x4004CC3")]
		[FieldOffset(Offset = "0x58")]
		private long m_SizeHashed;

		// Token: 0x04004CC4 RID: 19652
		[Token(Token = "0x4004CC4")]
		[FieldOffset(Offset = "0x60")]
		private byte[] m_Buffer;

		// Token: 0x04004CC5 RID: 19653
		[Token(Token = "0x4004CC5")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsFinished;

		// Token: 0x04004CC6 RID: 19654
		[Token(Token = "0x4004CC6")]
		[FieldOffset(Offset = "0x70")]
		private SHA1CryptoServiceProvider m_HashWorker;
	}
}
