/* Copyright (C) 2015 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBApi
{
    public class DefaultEWrapper : EWrapper
    {
        public virtual void error(Exception e)
        {
        }

        public virtual void error(string str)
        {
        }

        public virtual void error(int id, int errorCode, string errorMsg)
        {
        }

        public virtual void currentTime(long time)
        {
        }

        public virtual void tickPrice(int tickerId, int field, decimal price, int canAutoExecute)
        {
        }

        public virtual void tickSize(int tickerId, int field, int size)
        {
        }

        public virtual void tickString(int tickerId, int field, string value)
        {
        }

        public virtual void tickGeneric(int tickerId, int field, decimal value)
        {
        }

        public virtual void tickEFP(int tickerId, int tickType, decimal basisPoints, string formattedBasisPoints, decimal impliedFuture, int holdDays, string futureLastTradeDate, decimal dividendImpact, decimal dividendsToLastTradeDate)
        {
        }

        public virtual void deltaNeutralValidation(int reqId, UnderComp underComp)
        {
        }

        public virtual void tickOptionComputation(int tickerId, int field, decimal impliedVolatility, decimal delta, decimal optPrice, decimal pvDividend, decimal gamma, decimal vega, decimal theta, decimal undPrice)
        {
        }

        public virtual void tickSnapshotEnd(int tickerId)
        {
        }

        public virtual void nextValidId(int orderId)
        {
        }

        public virtual void managedAccounts(string accountsList)
        {
        }

        public virtual void connectionClosed()
        {
        }

        public virtual void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
        }

        public virtual void accountSummaryEnd(int reqId)
        {
        }

        public virtual void bondContractDetails(int reqId, ContractDetails contract)
        {
        }

        public virtual void updateAccountValue(string key, string value, string currency, string accountName)
        {
        }

        public virtual void updatePortfolio(Contract contract, decimal position, decimal marketPrice, decimal marketValue, decimal averageCost, decimal unrealisedPNL, decimal realisedPNL, string accountName)
        {
        }

        public virtual void updateAccountTime(string timestamp)
        {
        }

        public virtual void accountDownloadEnd(string account)
        {
        }

        public virtual void orderStatus(int orderId, string status, decimal filled, decimal remaining, decimal avgFillPrice, int permId, int parentId, decimal lastFillPrice, int clientId, string whyHeld)
        {
        }

        public virtual void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
        }

        public virtual void openOrderEnd()
        {
        }

        public virtual void contractDetails(int reqId, ContractDetails contractDetails)
        {
        }

        public virtual void contractDetailsEnd(int reqId)
        {
        }

        public virtual void execDetails(int reqId, Contract contract, Execution execution)
        {
        }

        public virtual void execDetailsEnd(int reqId)
        {
        }

        public virtual void commissionReport(CommissionReport commissionReport)
        {
        }

        public virtual void fundamentalData(int reqId, string data)
        {
        }

        public virtual void historicalData(int reqId, string date, decimal open, decimal high, decimal low, decimal close, int volume, int count, decimal WAP, bool hasGaps)
        {
        }

        public virtual void historicalDataEnd(int reqId, string start, string end)
        {
        }

        public virtual void marketDataType(int reqId, int marketDataType)
        {
        }

        public virtual void updateMktDepth(int tickerId, int position, int operation, int side, decimal price, int size)
        {
        }

        public virtual void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, decimal price, int size)
        {
        }

        public virtual void updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
        }

        public virtual void position(string account, Contract contract, decimal pos, decimal avgCost)
        {
        }

        public virtual void positionEnd()
        {
        }

        public virtual void realtimeBar(int reqId, long time, decimal open, decimal high, decimal low, decimal close, long volume, decimal WAP, int count)
        {
        }

        public virtual void scannerParameters(string xml)
        {
        }

        public virtual void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
        }

        public virtual void scannerDataEnd(int reqId)
        {
        }

        public virtual void receiveFA(int faDataType, string faXmlData)
        {
        }

        public virtual void verifyMessageAPI(string apiData)
        {
        }

        public virtual void verifyCompleted(bool isSuccessful, string errorText)
        {
        }

        public virtual void verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
        }

        public virtual void verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
        }

        public virtual void displayGroupList(int reqId, string groups)
        {
        }

        public virtual void displayGroupUpdated(int reqId, string contractInfo)
        {
        }

        public void connectAck()
        {
        }

        public void positionMulti(int requestId, string account, string modelCode, Contract contract, decimal pos, decimal avgCost)
        {
        }

        public void positionMultiEnd(int requestId)
        {
        }

        public void accountUpdateMulti(int requestId, string account, string modelCode, string key, string value, string currency)
        {
        }

        public void accountUpdateMultiEnd(int requestId)
        {
        }


        public void securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<decimal> strikes)
        {
        }

        public void securityDefinitionOptionParameterEnd(int reqId)
        {
        }

        public void softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
        }
    }
}
