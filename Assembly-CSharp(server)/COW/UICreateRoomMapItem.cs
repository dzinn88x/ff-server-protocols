using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001773 RID: 6003
	[Token(Token = "0x2001773")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F211C", Offset = "0x10F211C")]
	public class UICreateRoomMapItem : MonoBehaviour
	{
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		[Token(Token = "0x17000937")]
		public uint MapID
		{
			[Token(Token = "0x60071AD")]
			[Address(RVA = "0x1B9F1D4", Offset = "0x1B9F1D4", VA = "0x7BBC39F1D4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060071AE RID: 29102 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		[Token(Token = "0x17000938")]
		public uint GameMode
		{
			[Token(Token = "0x60071AE")]
			[Address(RVA = "0x1B9F1DC", Offset = "0x1B9F1DC", VA = "0x7BBC39F1DC")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060071AF RID: 29103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000939")]
		public string MapName
		{
			[Token(Token = "0x60071AF")]
			[Address(RVA = "0x1B9F1E4", Offset = "0x1B9F1E4", VA = "0x7BBC39F1E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B0")]
		[Address(RVA = "0x1B9F1EC", Offset = "0x1B9F1EC", VA = "0x7BBC39F1EC")]
		public void Start()
		{
		}

		// Token: 0x060071B1 RID: 29105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B1")]
		[Address(RVA = "0x1B9F374", Offset = "0x1B9F374", VA = "0x7BBC39F374")]
		public void SetData(uint mapID, uint gameMode)
		{
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B2")]
		[Address(RVA = "0x1B9F5B0", Offset = "0x1B9F5B0", VA = "0x7BBC39F5B0")]
		public void ClearData()
		{
		}

		// Token: 0x060071B3 RID: 29107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B3")]
		[Address(RVA = "0x1B9F628", Offset = "0x1B9F628", VA = "0x7BBC39F628")]
		private void OnMapToggleSelect()
		{
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B4")]
		[Address(RVA = "0x1B9F690", Offset = "0x1B9F690", VA = "0x7BBC39F690")]
		private void OnMapDownloadClick()
		{
		}

		// Token: 0x060071B5 RID: 29109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B5")]
		[Address(RVA = "0x1B9F70C", Offset = "0x1B9F70C", VA = "0x7BBC39F70C")]
		public UICreateRoomMapItem()
		{
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B6")]
		[Address(RVA = "0x1B9F764", Offset = "0x1B9F764", VA = "0x7BBC39F764")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114186C", Offset = "0x114186C")]
		private void <Start>b__16_0(UIToggleButton x)
		{
		}

		// Token: 0x04008B07 RID: 35591
		[Token(Token = "0x4008B07")]
		[FieldOffset(Offset = "0x18")]
		public UISprite m_MapImg;

		// Token: 0x04008B08 RID: 35592
		[Token(Token = "0x4008B08")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton m_MapToggle;

		// Token: 0x04008B09 RID: 35593
		[Token(Token = "0x4008B09")]
		[FieldOffset(Offset = "0x28")]
		public GameObject m_LockBG;

		// Token: 0x04008B0A RID: 35594
		[Token(Token = "0x4008B0A")]
		[FieldOffset(Offset = "0x30")]
		public UIButton m_DownloadBtn;

		// Token: 0x04008B0B RID: 35595
		[Token(Token = "0x4008B0B")]
		[FieldOffset(Offset = "0x38")]
		public UILabel m_MapNameTxt;

		// Token: 0x04008B0C RID: 35596
		[Token(Token = "0x4008B0C")]
		[FieldOffset(Offset = "0x40")]
		private uint m_MapID;

		// Token: 0x04008B0D RID: 35597
		[Token(Token = "0x4008B0D")]
		[FieldOffset(Offset = "0x44")]
		private uint m_GameMode;

		// Token: 0x04008B0E RID: 35598
		[Token(Token = "0x4008B0E")]
		[FieldOffset(Offset = "0x48")]
		private string m_MapName;

		// Token: 0x04008B0F RID: 35599
		[Token(Token = "0x4008B0F")]
		[FieldOffset(Offset = "0x50")]
		public SelectMapItemDelegate fnSelectMapItem;

		// Token: 0x04008B10 RID: 35600
		[Token(Token = "0x4008B10")]
		[FieldOffset(Offset = "0x58")]
		public DownloadMapItemDelegate fnDownloadMapItem;
	}
}
