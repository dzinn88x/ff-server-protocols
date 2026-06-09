using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F05 RID: 3845
	[Token(Token = "0x2000F05")]
	public class LocGlobalComponent : MonoBehaviour
	{
		// Token: 0x06003627 RID: 13863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003627")]
		[Address(RVA = "0x2121EB0", Offset = "0x2121EB0", VA = "0x7BBC921EB0")]
		public LocGlobalComponent()
		{
		}

		// Token: 0x04004963 RID: 18787
		[Token(Token = "0x4004963")]
		[FieldOffset(Offset = "0x18")]
		public List<LocLang> SupportedLanguages;

		// Token: 0x04004964 RID: 18788
		[Token(Token = "0x4004964")]
		[FieldOffset(Offset = "0x20")]
		public List<LocGlobalComponent.LocFontSet> FontSetting;

		// Token: 0x02000F06 RID: 3846
		[Token(Token = "0x2000F06")]
		[Serializable]
		public class LocFontSet
		{
			// Token: 0x06003628 RID: 13864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003628")]
			[Address(RVA = "0x2121EB8", Offset = "0x2121EB8", VA = "0x7BBC921EB8")]
			public LocFontSet()
			{
			}

			// Token: 0x04004965 RID: 18789
			[Token(Token = "0x4004965")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04004966 RID: 18790
			[Token(Token = "0x4004966")]
			[FieldOffset(Offset = "0x18")]
			public List<LocGlobalComponent.LocFontSet.LocFont> Fonts;

			// Token: 0x02000F07 RID: 3847
			[Token(Token = "0x2000F07")]
			[Serializable]
			public class LocFont
			{
				// Token: 0x170006B9 RID: 1721
				// (get) Token: 0x06003629 RID: 13865 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170006B9")]
				public Font Font
				{
					[Token(Token = "0x6003629")]
					[Address(RVA = "0x2121EC0", Offset = "0x2121EC0", VA = "0x7BBC921EC0")]
					get
					{
						return null;
					}
				}

				// Token: 0x0600362A RID: 13866 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600362A")]
				[Address(RVA = "0x2122150", Offset = "0x2122150", VA = "0x7BBC922150")]
				public LocFont()
				{
				}

				// Token: 0x04004967 RID: 18791
				[Token(Token = "0x4004967")]
				[FieldOffset(Offset = "0x10")]
				public LocLang Lang;

				// Token: 0x04004968 RID: 18792
				[Token(Token = "0x4004968")]
				[FieldOffset(Offset = "0x18")]
				private Font m_Font;

				// Token: 0x04004969 RID: 18793
				[Token(Token = "0x4004969")]
				[FieldOffset(Offset = "0x20")]
				public string FontResource;
			}
		}
	}
}
