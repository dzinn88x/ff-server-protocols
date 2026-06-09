using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016F8 RID: 5880
	[Token(Token = "0x20016F8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F12E4", Offset = "0x10F12E4")]
	public class UIChatCommonContainerController : UIChatBaseContainerController
	{
		// Token: 0x06006D39 RID: 27961 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		[Token(Token = "0x6006D39")]
		[Address(RVA = "0x1BE17B4", Offset = "0x1BE17B4", VA = "0x7BBC3E17B4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D3A RID: 27962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3A")]
		[Address(RVA = "0x1BE1804", Offset = "0x1BE1804", VA = "0x7BBC3E1804", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3B")]
		[Address(RVA = "0x1BE1868", Offset = "0x1BE1868", VA = "0x7BBC3E1868", Slot = "28")]
		public override GameObject GetContentNode()
		{
			return null;
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3C")]
		[Address(RVA = "0x1BE1894", Offset = "0x1BE1894", VA = "0x7BBC3E1894", Slot = "29")]
		public override GameObject GetEmptyNode()
		{
			return null;
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3D")]
		[Address(RVA = "0x1BE18C0", Offset = "0x1BE18C0", VA = "0x7BBC3E18C0", Slot = "30")]
		public override UIScrollView GetMessageList()
		{
			return null;
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3E")]
		[Address(RVA = "0x1BE18EC", Offset = "0x1BE18EC", VA = "0x7BBC3E18EC", Slot = "32")]
		public override void RefreshContentNode()
		{
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3F")]
		[Address(RVA = "0x1BE18F0", Offset = "0x1BE18F0", VA = "0x7BBC3E18F0", Slot = "31")]
		public override void InitWidget(Transform parent)
		{
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D40")]
		[Address(RVA = "0x1BE196C", Offset = "0x1BE196C", VA = "0x7BBC3E196C")]
		public UIChatCommonContainerController()
		{
		}

		// Token: 0x04008880 RID: 34944
		[Token(Token = "0x4008880")]
		[FieldOffset(Offset = "0x58")]
		private UIChatCommonContainerView m_View;
	}
}
