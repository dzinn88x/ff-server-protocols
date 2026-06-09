using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020012A1 RID: 4769
	[Token(Token = "0x20012A1")]
	public class PreviewStoryCgCdnComp : MonoBehaviour
	{
		// Token: 0x06004A99 RID: 19097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A99")]
		[Address(RVA = "0x174A128", Offset = "0x174A128", VA = "0x7BBBF4A128")]
		protected void Awake()
		{
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9A")]
		[Address(RVA = "0x174A2A0", Offset = "0x174A2A0", VA = "0x7BBBF4A2A0")]
		public void RefreshMainTitleCdnTex(string url)
		{
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9B")]
		[Address(RVA = "0x174A4CC", Offset = "0x174A4CC", VA = "0x7BBBF4A4CC")]
		public PreviewStoryCgCdnComp()
		{
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x000167E8 File Offset: 0x000149E8
		[Token(Token = "0x6004A9C")]
		[Address(RVA = "0x174A4D4", Offset = "0x174A4D4", VA = "0x7BBBF4A4D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DC80", Offset = "0x113DC80")]
		private bool <Awake>b__5_0(AdvertDesc x)
		{
			return default(bool);
		}

		// Token: 0x040072E5 RID: 29413
		[Token(Token = "0x40072E5")]
		[FieldOffset(Offset = "0x18")]
		public UINetworkTexture m_Typetitlenettex;

		// Token: 0x040072E6 RID: 29414
		[Token(Token = "0x40072E6")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture m_Maintitlenettex;

		// Token: 0x040072E7 RID: 29415
		[Token(Token = "0x40072E7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject m_Maintitledefault;

		// Token: 0x040072E8 RID: 29416
		[Token(Token = "0x40072E8")]
		[FieldOffset(Offset = "0x30")]
		public uint CdnMainId;

		// Token: 0x040072E9 RID: 29417
		[Token(Token = "0x40072E9")]
		[FieldOffset(Offset = "0x34")]
		public uint CdnTypeId;
	}
}
