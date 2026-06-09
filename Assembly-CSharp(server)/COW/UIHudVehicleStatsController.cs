using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001990 RID: 6544
	[Token(Token = "0x2001990")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6954", Offset = "0x10F6954")]
	public class UIHudVehicleStatsController : UIBaseController
	{
		// Token: 0x06008588 RID: 34184 RVA: 0x00024360 File Offset: 0x00022560
		[Token(Token = "0x6008588")]
		[Address(RVA = "0x15F1990", Offset = "0x15F1990", VA = "0x7BBBDF1990")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008589 RID: 34185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008589")]
		[Address(RVA = "0x15F19E0", Offset = "0x15F19E0", VA = "0x7BBBDF19E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600858A RID: 34186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600858A")]
		[Address(RVA = "0x15F1A90", Offset = "0x15F1A90", VA = "0x7BBBDF1A90", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600858B RID: 34187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600858B")]
		[Address(RVA = "0x15F1E9C", Offset = "0x15F1E9C", VA = "0x7BBBDF1E9C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600858C RID: 34188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600858C")]
		[Address(RVA = "0x15F20B8", Offset = "0x15F20B8", VA = "0x7BBBDF20B8")]
		private void OnHPChanged(params object[] data)
		{
		}

		// Token: 0x0600858D RID: 34189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600858D")]
		[Address(RVA = "0x15F2480", Offset = "0x15F2480", VA = "0x7BBBDF2480")]
		private void OnGetOn(params object[] data)
		{
		}

		// Token: 0x0600858E RID: 34190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600858E")]
		[Address(RVA = "0x15F2714", Offset = "0x15F2714", VA = "0x7BBBDF2714")]
		private void Update()
		{
		}

		// Token: 0x0600858F RID: 34191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600858F")]
		[Address(RVA = "0x15F27A8", Offset = "0x15F27A8", VA = "0x7BBBDF27A8")]
		private void UpdateSpeed()
		{
		}

		// Token: 0x06008590 RID: 34192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008590")]
		[Address(RVA = "0x15F29D8", Offset = "0x15F29D8", VA = "0x7BBBDF29D8")]
		private void UpdateSpeedPointer(int speed)
		{
		}

		// Token: 0x06008591 RID: 34193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008591")]
		[Address(RVA = "0x15F2260", Offset = "0x15F2260", VA = "0x7BBBDF2260")]
		private void RefreshHP()
		{
		}

		// Token: 0x06008592 RID: 34194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008592")]
		[Address(RVA = "0x15F2AD8", Offset = "0x15F2AD8", VA = "0x7BBBDF2AD8")]
		private void OnLocalVehcleLevelUp(object[] data)
		{
		}

		// Token: 0x06008593 RID: 34195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008593")]
		[Address(RVA = "0x15F2BDC", Offset = "0x15F2BDC", VA = "0x7BBBDF2BDC")]
		private void OnVehicleEquipmentChanged(params object[] data)
		{
		}

		// Token: 0x06008594 RID: 34196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008594")]
		[Address(RVA = "0x15F2CDC", Offset = "0x15F2CDC", VA = "0x7BBBDF2CDC")]
		private void RefreshVehicleEquipmentStats(LevelVehicle veh)
		{
		}

		// Token: 0x06008595 RID: 34197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008595")]
		[Address(RVA = "0x15F2E74", Offset = "0x15F2E74", VA = "0x7BBBDF2E74")]
		public UIHudVehicleStatsController()
		{
		}

		// Token: 0x0400950B RID: 38155
		[Token(Token = "0x400950B")]
		[FieldOffset(Offset = "0x58")]
		private UIHudVehicleStatsView m_View;

		// Token: 0x0400950C RID: 38156
		[Token(Token = "0x400950C")]
		[FieldOffset(Offset = "0x60")]
		private Vehicle m_Vehicle;

		// Token: 0x0400950D RID: 38157
		[Token(Token = "0x400950D")]
		private const int SPEED_SAMPLE_COUNT = 10;

		// Token: 0x0400950E RID: 38158
		[Token(Token = "0x400950E")]
		[FieldOffset(Offset = "0x68")]
		private float m_SpeedSum;

		// Token: 0x0400950F RID: 38159
		[Token(Token = "0x400950F")]
		[FieldOffset(Offset = "0x70")]
		private Queue<float> m_Speeds;

		// Token: 0x04009510 RID: 38160
		[Token(Token = "0x4009510")]
		[FieldOffset(Offset = "0x78")]
		private StringBuilder mLabelBuilder;

		// Token: 0x04009511 RID: 38161
		[Token(Token = "0x4009511")]
		[FieldOffset(Offset = "0x80")]
		private int mLastSpeed;

		// Token: 0x04009512 RID: 38162
		[Token(Token = "0x4009512")]
		[FieldOffset(Offset = "0x84")]
		private float eulerPerKm;

		// Token: 0x04009513 RID: 38163
		[Token(Token = "0x4009513")]
		[FieldOffset(Offset = "0x88")]
		private float zRotation;

		// Token: 0x04009514 RID: 38164
		[Token(Token = "0x4009514")]
		[FieldOffset(Offset = "0x90")]
		private List<GameObject> m_Upgrades;

		// Token: 0x04009515 RID: 38165
		[Token(Token = "0x4009515")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 m_InitPosition;

		// Token: 0x04009516 RID: 38166
		[Token(Token = "0x4009516")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 m_SpeedModeDriverPosition;
	}
}
