using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018FF RID: 6399
	[Token(Token = "0x20018FF")]
	public class UIHudLocalPlayerKilledController : UIBaseController
	{
		// Token: 0x06008089 RID: 32905 RVA: 0x000230B8 File Offset: 0x000212B8
		[Token(Token = "0x6008089")]
		[Address(RVA = "0x15BAE20", Offset = "0x15BAE20", VA = "0x7BBBDBAE20")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600808A RID: 32906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808A")]
		[Address(RVA = "0x15BAE70", Offset = "0x15BAE70", VA = "0x7BBBDBAE70", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600808B RID: 32907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808B")]
		[Address(RVA = "0x15BAFC4", Offset = "0x15BAFC4", VA = "0x7BBBDBAFC4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808C")]
		[Address(RVA = "0x15BB090", Offset = "0x15BB090", VA = "0x7BBBDBB090")]
		public void OnLocalPlayerKilled(params object[] data)
		{
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808D")]
		[Address(RVA = "0x15BB840", Offset = "0x15BB840", VA = "0x7BBBDBB840")]
		private void Update()
		{
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808E")]
		[Address(RVA = "0x15BB96C", Offset = "0x15BB96C", VA = "0x7BBBDBB96C")]
		public UIHudLocalPlayerKilledController()
		{
		}

		// Token: 0x040092B2 RID: 37554
		[Token(Token = "0x40092B2")]
		[FieldOffset(Offset = "0x58")]
		private UIHudLocalPlayerKilledView m_View;

		// Token: 0x040092B3 RID: 37555
		[Token(Token = "0x40092B3")]
		[FieldOffset(Offset = "0x60")]
		private UIBaseProfileInfoController m_Profile;

		// Token: 0x040092B4 RID: 37556
		[Token(Token = "0x40092B4")]
		[FieldOffset(Offset = "0x68")]
		private TypewriterEffect m_WriterEffect;

		// Token: 0x040092B5 RID: 37557
		[Token(Token = "0x40092B5")]
		private const float C_ALPHA_BLEND_TIME = 2f;

		// Token: 0x040092B6 RID: 37558
		[Token(Token = "0x40092B6")]
		[FieldOffset(Offset = "0x70")]
		private float m_alphaBlendTime;
	}
}
