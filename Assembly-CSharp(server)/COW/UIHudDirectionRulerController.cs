using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018AB RID: 6315
	[Token(Token = "0x20018AB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4894", Offset = "0x10F4894")]
	public class UIHudDirectionRulerController : UIBaseController
	{
		// Token: 0x06007D77 RID: 32119 RVA: 0x00022638 File Offset: 0x00020838
		[Token(Token = "0x6007D77")]
		[Address(RVA = "0x1BFBEC4", Offset = "0x1BFBEC4", VA = "0x7BBC3FBEC4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D78 RID: 32120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D78")]
		[Address(RVA = "0x1BFBF14", Offset = "0x1BFBF14", VA = "0x7BBC3FBF14", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D79 RID: 32121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D79")]
		[Address(RVA = "0x1BFD220", Offset = "0x1BFD220", VA = "0x7BBC3FD220", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007D7A RID: 32122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D7A")]
		[Address(RVA = "0x1BFD430", Offset = "0x1BFD430", VA = "0x7BBC3FD430")]
		private void Update()
		{
		}

		// Token: 0x06007D7B RID: 32123 RVA: 0x00022650 File Offset: 0x00020850
		[Token(Token = "0x6007D7B")]
		[Address(RVA = "0x1BFD778", Offset = "0x1BFD778", VA = "0x7BBC3FD778")]
		private float GetRotationAngleFromView()
		{
			return 0f;
		}

		// Token: 0x06007D7C RID: 32124 RVA: 0x00022668 File Offset: 0x00020868
		[Token(Token = "0x6007D7C")]
		[Address(RVA = "0x1BFE18C", Offset = "0x1BFE18C", VA = "0x7BBC3FE18C")]
		private float GetFinalRulerScaleByVector3(Vector3 v)
		{
			return 0f;
		}

		// Token: 0x06007D7D RID: 32125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D7D")]
		[Address(RVA = "0x1BFD9E8", Offset = "0x1BFD9E8", VA = "0x7BBC3FD9E8")]
		private void UpdateMarkAndSaveZoneDirection(int startDirection)
		{
		}

		// Token: 0x06007D7E RID: 32126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D7E")]
		[Address(RVA = "0x1BFE280", Offset = "0x1BFE280", VA = "0x7BBC3FE280")]
		private void UpdateMarkUI(int startDirection, Vector3 markPos, Transform markSprite)
		{
		}

		// Token: 0x06007D7F RID: 32127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D7F")]
		[Address(RVA = "0x1BFE60C", Offset = "0x1BFE60C", VA = "0x7BBC3FE60C")]
		private void OnRemoveMapMark(object[] data)
		{
		}

		// Token: 0x06007D80 RID: 32128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D80")]
		[Address(RVA = "0x1BFE7EC", Offset = "0x1BFE7EC", VA = "0x7BBC3FE7EC")]
		private void OnUpdateMapMark(object[] data)
		{
		}

		// Token: 0x06007D81 RID: 32129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D81")]
		[Address(RVA = "0x1BFEA88", Offset = "0x1BFEA88", VA = "0x7BBC3FEA88")]
		private void OnTreasureMarked(params object[] param)
		{
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D82")]
		[Address(RVA = "0x1BFED30", Offset = "0x1BFED30", VA = "0x7BBC3FED30")]
		private void OnTreasureContainerDelete(params object[] param)
		{
		}

		// Token: 0x06007D83 RID: 32131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D83")]
		[Address(RVA = "0x1BFEEE0", Offset = "0x1BFEEE0", VA = "0x7BBC3FEEE0")]
		private void OnStartMatchEndShow(object[] data)
		{
		}

		// Token: 0x06007D84 RID: 32132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D84")]
		[Address(RVA = "0x1BFEEE8", Offset = "0x1BFEEE8", VA = "0x7BBC3FEEE8")]
		public UIHudDirectionRulerController()
		{
		}

		// Token: 0x04009109 RID: 37129
		[Token(Token = "0x4009109")]
		[FieldOffset(Offset = "0x58")]
		private UIHudDirectionRulerView m_View;

		// Token: 0x0400910A RID: 37130
		[Token(Token = "0x400910A")]
		[FieldOffset(Offset = "0x60")]
		private Player m_Player;

		// Token: 0x0400910B RID: 37131
		[Token(Token = "0x400910B")]
		[FieldOffset(Offset = "0x68")]
		private UILabel[] m_ScaleValues;

		// Token: 0x0400910C RID: 37132
		[Token(Token = "0x400910C")]
		[FieldOffset(Offset = "0x70")]
		private UISprite[] m_TeamMark;

		// Token: 0x0400910D RID: 37133
		[Token(Token = "0x400910D")]
		[FieldOffset(Offset = "0x78")]
		private float m_RulerPosY;

		// Token: 0x0400910E RID: 37134
		[Token(Token = "0x400910E")]
		[FieldOffset(Offset = "0x7C")]
		private float m_TeamMarkPosY;

		// Token: 0x0400910F RID: 37135
		[Token(Token = "0x400910F")]
		[FieldOffset(Offset = "0x80")]
		private int m_NumScaleInternal;

		// Token: 0x04009110 RID: 37136
		[Token(Token = "0x4009110")]
		[FieldOffset(Offset = "0x88")]
		private Vector3[] m_TeamMarkPos;

		// Token: 0x04009111 RID: 37137
		[Token(Token = "0x4009111")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 m_SinglePlayerMarkPos;

		// Token: 0x04009112 RID: 37138
		[Token(Token = "0x4009112")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 m_SaveZonePos;

		// Token: 0x04009113 RID: 37139
		[Token(Token = "0x4009113")]
		[FieldOffset(Offset = "0xA8")]
		private SafeZone m_SafeZone;

		// Token: 0x04009114 RID: 37140
		[Token(Token = "0x4009114")]
		[FieldOffset(Offset = "0xB0")]
		private float m_ScaleDisDelta;

		// Token: 0x04009115 RID: 37141
		[Token(Token = "0x4009115")]
		private const int m_AngleInterval = 15;

		// Token: 0x04009116 RID: 37142
		[Token(Token = "0x4009116")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 hideMarkPosition;

		// Token: 0x04009117 RID: 37143
		[Token(Token = "0x4009117")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<int, string> m_ScaleStringDic;

		// Token: 0x04009118 RID: 37144
		[Token(Token = "0x4009118")]
		[FieldOffset(Offset = "0xC8")]
		private bool isSolo;

		// Token: 0x04009119 RID: 37145
		[Token(Token = "0x4009119")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<uint, GameObject> m_TreasureMarkDict;

		// Token: 0x0400911A RID: 37146
		[Token(Token = "0x400911A")]
		[FieldOffset(Offset = "0xD8")]
		private Dictionary<uint, Vector3> m_TreasureMarkPosDict;

		// Token: 0x0400911B RID: 37147
		[Token(Token = "0x400911B")]
		private const float m_length = 432f;

		// Token: 0x0400911C RID: 37148
		[Token(Token = "0x400911C")]
		[FieldOffset(Offset = "0xE0")]
		private float m_ruler1PosX;

		// Token: 0x0400911D RID: 37149
		[Token(Token = "0x400911D")]
		[FieldOffset(Offset = "0xE4")]
		private float m_ruler2PosX;
	}
}
