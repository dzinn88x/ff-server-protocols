using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FFC RID: 4092
	[Token(Token = "0x2000FFC")]
	public class ResourceRefCache
	{
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06003D13 RID: 15635 RVA: 0x00013218 File Offset: 0x00011418
		[Token(Token = "0x1700071C")]
		public int LoadedResourcesCount
		{
			[Token(Token = "0x6003D13")]
			[Address(RVA = "0x248D454", Offset = "0x248D454", VA = "0x7BBCC8D454")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D14")]
		[Address(RVA = "0x248D4B4", Offset = "0x248D4B4", VA = "0x7BBCC8D4B4")]
		public UnityEngine.Object GetResource(ResourceID id, bool notUsingABForcefully = false, [Optional] Type type)
		{
			return null;
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D15")]
		[Address(RVA = "0x248D674", Offset = "0x248D674", VA = "0x7BBCC8D674")]
		public void ClearResource(ResourceID id, bool isUnloadAsset = true)
		{
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D16")]
		[Address(RVA = "0x24860D4", Offset = "0x24860D4", VA = "0x7BBCC860D4")]
		public void OnClearResource(ResourceID id)
		{
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D17")]
		[Address(RVA = "0x248640C", Offset = "0x248640C", VA = "0x7BBCC8640C")]
		public void Clear()
		{
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D18")]
		[Address(RVA = "0x248765C", Offset = "0x248765C", VA = "0x7BBCC8765C")]
		public ResourceRefCache()
		{
		}

		// Token: 0x04004E16 RID: 19990
		[Token(Token = "0x4004E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool ClearOnQualityChange;

		// Token: 0x04004E17 RID: 19991
		[Token(Token = "0x4004E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private GGfm}Dt m_CurrentQuality;

		// Token: 0x04004E18 RID: 19992
		[Token(Token = "0x4004E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<ResourceID, UnityEngine.Object> m_LoadedResources;
	}
}
